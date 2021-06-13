using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TP5.classes;

namespace TP5
{
    public partial class Form1 : Form
    {
        List<int> ordenDeLosClientesPorId;
        List<string> ordenDeLosClientesPorDisciplina;
        GestorSimulacion simulador;
        public Form1()
        {
            InitializeComponent();
            this.simulador = new GestorSimulacion();
            this.ordenDeLosClientesPorId = new List<int>();
            this.ordenDeLosClientesPorDisciplina = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Resetear grilla
            dataGridView1.Rows.Clear();
            for (int i = dataGridView1.Columns.Count-1; i > 37; i--)
            {
                dataGridView1.Columns.RemoveAt(i);
            }
            this.ordenDeLosClientesPorDisciplina.Clear();
            this.ordenDeLosClientesPorId.Clear();

            //Validar parametros ingresados
            if (!this.validarDatos())
                return;

            //Extraer parametros
            double mediaB = Convert.ToDouble(txtMediaB.Text);
            double desvB = Convert.ToDouble(txtDesvB.Text);
            double mediaF = Convert.ToDouble(txtMediaF.Text);
            double mediaH = Convert.ToDouble(txtMediaH.Text);
            double desvH = Convert.ToDouble(txtDesvH.Text);

            double OMediaB = Convert.ToDouble(txtOMediaB.Text);
            double OAmpB = Convert.ToDouble(txtOAmpB.Text);
            double OMediaF = Convert.ToDouble(txtOMediaF.Text);
            double ODesvF = Convert.ToDouble(txtODesvF.Text);
            double OMediaH = Convert.ToDouble(txtOMediaH.Text);
            double ODesvH = Convert.ToDouble(txtODesvH.Text);

            double DBasket = Convert.ToDouble(txtDBasket.Text);
            double DFutbol = Convert.ToDouble(txtDFutbol.Text);
            double DHandball = Convert.ToDouble(txtDHandball.Text);
            double h = Convert.ToDouble(txtH.Text);

            double horaFin = Convert.ToDouble(txtHoraFin.Text);
            int iteraciones = Convert.ToInt32(txtIteraciones.Text);

            double horaDesde;
            int iteracionesHasta;

            double[][] parametros = new double[][] {
                new double[] { DBasket, DFutbol, DHandball },
                new double[] { mediaB, desvB },
                new double[] { mediaF },
                new double[] { mediaH, desvH },
                new double[] { OMediaB, OAmpB },
                new double[] { OMediaF, ODesvF },
                new double[] { OMediaH, ODesvH },
                new double[] { h }
            };
            List<object[]> resultados;
            if (chkEstadosInter.Checked)
            {
                horaDesde = Convert.ToDouble(txtHoraDesde.Text);
                iteracionesHasta = Convert.ToInt32(txtIteracionesHasta.Text);
                resultados = this.simulador.simular(horaFin, iteraciones, parametros, horaDesde, iteracionesHasta);
            }
            else
            { 
                resultados = this.simulador.simular(horaFin, iteraciones, parametros);
            }

           //Formateo de resultados
           List<string[]> resFormateados = new List<string[]>();
            foreach (object[] fila in resultados) {
                resFormateados.Add(this.armarFila(fila));
            }

            //Chequear si el largo de los resultados formateados no excede la cantidad de columnas máxima posible
            if(resFormateados[0].Length > 654)
            {
                MessageBox.Show("La cantidad de columnas generadas excede el máximo permitido", "Error de grilla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Adaptar la grilla segun resultados formateados

            for (int i = 0; i < this.ordenDeLosClientesPorId.Count; i++)
            {
                dataGridView1.Columns.Add("estado_" + this.ordenDeLosClientesPorDisciplina[i].ToLower() + "_" + this.ordenDeLosClientesPorId[i].ToString(),
                                          "Estado " + this.ordenDeLosClientesPorDisciplina[i] + " " + this.ordenDeLosClientesPorId[i].ToString());
                dataGridView1.Columns.Add("hora_llegada", "Hora llegada");
                dataGridView1.Columns.Add("hora_juego", "Hora juego");
            }

            //Agregar resultados a la grilla
            foreach (string[] fila in resFormateados) {
                dataGridView1.Rows.Add(fila);
            }

            //Calcular datos pedidos por el ejercicio y mostrarlos
            object[] ultimoEstado = resultados[resultados.Count - 1];
            int contadorB = Convert.ToInt32(ultimoEstado[31]);
            int contadorF = Convert.ToInt32(ultimoEstado[32]);
            int contadorH = Convert.ToInt32(ultimoEstado[33]);
            double promB = 0;
            double promF = 0;
            double promH = 0;
            if(contadorB != 0)
            {
                promB = this.truncar(Convert.ToDouble(ultimoEstado[34]) / contadorB, 4);
            }
            if (contadorF != 0)
            {
                promF = this.truncar(Convert.ToDouble(ultimoEstado[35]) / contadorF, 4);
            }
            if (contadorH != 0)
            {
                promH = this.truncar(Convert.ToDouble(ultimoEstado[36]) / contadorH, 4);
            }


            lblPromB.Text = promB.ToString();
            lblPromF.Text = promF.ToString();
            lblPromH.Text = promH.ToString();

            double tasaOcupacion = this.truncar(Convert.ToDouble(ultimoEstado[37])/Convert.ToDouble(ultimoEstado[1])*100 ,4);
            lblTasaOcupacion.Text = tasaOcupacion.ToString() + "%";
        }

        private bool validarDatos()
        {
            if (!Double.TryParse(txtMediaB.Text, out double mediaB))
            {
                MessageBox.Show("La media de tiempo de llegada de grupos de basketball debe ser un numero con coma flotante", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (mediaB < 0)
            {
                MessageBox.Show("La media de tiempo de llegada de grupos de basketball debe ser un numero positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(txtDesvB.Text, out double desvB))
            {
                MessageBox.Show("La desviación de tiempo de llegada de grupos de basketball debe ser un numero con coma flotante", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (desvB < 0)
            {
                MessageBox.Show("La desviación de tiempo de llegada de grupos de basketball debe ser un numero positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(txtMediaF.Text, out double mediaF))
            {
                MessageBox.Show("La media de tiempo de llegada de grupos de futbol debe ser un numero con coma flotante", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (mediaF < 0)
            {
                MessageBox.Show("La media de tiempo de llegada de grupos de futbol debe ser un numero positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(txtMediaH.Text, out double mediaH))
            {
                MessageBox.Show("La media de tiempo de llegada de grupos de handball debe ser un numero con coma flotante", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (mediaH < 0)
            {
                MessageBox.Show("La media de tiempo de llegada de grupos de handball debe ser un numero positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(txtDesvH.Text, out double desvH))
            {
                MessageBox.Show("La desviación de tiempo de llegada de grupos de handball debe ser un numero con coma flotante", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (desvH < 0)
            {
                MessageBox.Show("La desviación de tiempo de llegada de grupos de handball debe ser un numero positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(txtOMediaB.Text, out double OmediaB))
            {
                MessageBox.Show("La media de tiempo de ocupación de cancha de grupos de basketball debe ser un numero con coma flotante", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (OmediaB < 0)
            {
                MessageBox.Show("La media de tiempo de ocupación de cancha de grupos de basketball debe ser un numero positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(txtOAmpB.Text, out double OAmpB))
            {
                MessageBox.Show("La amplitud de tiempo de ocupación de cancha de grupos de basketball debe ser un numero con coma flotante", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (OAmpB < 0)
            {
                MessageBox.Show("La amplitud de tiempo de ocupación de cancha de grupos de basketball debe ser un numero positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(txtOMediaF.Text, out double OmediaF))
            {
                MessageBox.Show("La media de tiempo de tiempo de ocupación de cancha de grupos de futbol debe ser un numero con coma flotante", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (OmediaF < 0)
            {
                MessageBox.Show("La media de tiempo de tiempo de ocupación de cancha de grupos de futbol debe ser un numero positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(txtODesvH.Text, out double OdesvF))
            {
                MessageBox.Show("La desviación de tiempo de tiempo de ocupación de cancha de grupos de futbol debe ser un numero con coma flotante", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (OdesvF < 0)
            {
                MessageBox.Show("La desviación de tiempo de tiempo de ocupación de cancha de grupos de futbol debe ser un numero positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(txtOMediaH.Text, out double OmediaH))
            {
                MessageBox.Show("La media de tiempo de tiempo de ocupación de cancha de grupos de handball debe ser un numero con coma flotante", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (OmediaH < 0)
            {
                MessageBox.Show("La media de tiempo de tiempo de ocupación de cancha de grupos de handball debe ser un numero positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(txtODesvF.Text, out double OdesvH))
            {
                MessageBox.Show("La desviación de tiempo de tiempo de ocupación de cancha de grupos de handball debe ser un numero con coma flotante", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (OdesvH < 0)
            {
                MessageBox.Show("La desviación de tiempo de tiempo de ocupación de cancha de grupos de handball debe ser un numero positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(txtHoraFin.Text, out double horaFin))
            {
                MessageBox.Show("La hora de fin de la simulación debe ser un numero con coma flotante", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (horaFin < 0)
            {
                MessageBox.Show("La hora de fin de la simulación debe ser un numero positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Int32.TryParse(txtIteraciones.Text, out int iteraciones))
            {
                MessageBox.Show("Las iteraciones de la simulación deben ser un numero entero", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (iteraciones < 0)
            {
                MessageBox.Show("Las iteraciones de la simulación deben ser un numero positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(txtHoraDesde.Text, out double horaDesde))
            {
                MessageBox.Show("La hora desde la que ver los vectores de estado debe ser un numero con coma flotante", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (horaDesde < 0)
            {
                MessageBox.Show("La hora desde la que ver los vectores de estado debe ser un numero positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Int32.TryParse(txtIteracionesHasta.Text, out int iteracionesHasta))
            {
                MessageBox.Show("La cantidad de iteraciones a ver debe ser un numero entero", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (iteracionesHasta < 0)
            {
                MessageBox.Show("La cantidad de iteraciones a ver debe ser un numero positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private string[] armarFila(object[] vector)
        {
            string evento = (string)vector[0];
            string reloj = this.truncar((double)vector[1], 4).ToString();
            string tiempoAcond = String.IsNullOrEmpty((string)vector[2]) ? (string)vector[2] : this.truncar(Convert.ToDouble(vector[2]), 4).ToString();
            string finAcond = String.IsNullOrEmpty((string)vector[3]) ? (string)vector[3] : this.truncar(Convert.ToDouble(vector[3]), 4).ToString();
            List<string> rndEventos = new List<string>();
            List<string> tiempoEventos = new List<string>();
            List<string> proxEventos = new List<string>();
            List<int> iEventosNormales = new List<int> { 4, 11, 21, 25 };
            for (int i = 4; i < 29; i+=3)
            {
                rndEventos.Add(String.IsNullOrEmpty((string)vector[i]) ? (string)vector[i] : this.truncar(Convert.ToDouble(vector[i]), 4).ToString());
                if(iEventosNormales.Contains(i))
                {
                    i++;
                    rndEventos.Add(String.IsNullOrEmpty((string)vector[i]) ? (string)vector[i] : this.truncar(Convert.ToDouble(vector[i]), 4).ToString());
                }
                tiempoEventos.Add(String.IsNullOrEmpty((string)vector[i+1]) ? (string)vector[i+1] : this.truncar(Convert.ToDouble(vector[i+1]), 4).ToString());
                proxEventos.Add(String.IsNullOrEmpty((string)vector[i+2]) ? (string)vector[i+2] : this.truncar(Convert.ToDouble(vector[i+2]), 4).ToString());
            }
            string estadoCancha = (string)vector[29];
            string colaCancha = vector[30].ToString();
            string contadorBasket = vector[31].ToString();
            string contadorFutbol = vector[32].ToString();
            string contadorHandball = vector[33].ToString();
            string acumEsperaBasket = String.IsNullOrEmpty(vector[34].ToString()) ? (string)vector[34] : this.truncar(Convert.ToDouble(vector[34]), 4).ToString();
            string acumEsperaFutbol = String.IsNullOrEmpty(vector[35].ToString()) ? (string)vector[35] : this.truncar(Convert.ToDouble(vector[35]), 4).ToString();
            string acumEsperaHandball = String.IsNullOrEmpty(vector[36].ToString()) ? (string)vector[36] : this.truncar(Convert.ToDouble(vector[36]), 4).ToString();
            string acumOcupacion = String.IsNullOrEmpty(vector[37].ToString()) ? (string)vector[37] : this.truncar(Convert.ToDouble(vector[37]), 4).ToString();

            string[] vectorSinClientes = new string[]
            {
                evento, reloj, tiempoAcond, finAcond,
                rndEventos[0], rndEventos[1], tiempoEventos[0], proxEventos[0],
                rndEventos[2], tiempoEventos[1], proxEventos[1],
                rndEventos[3], rndEventos[4], tiempoEventos[2], proxEventos[2],
                rndEventos[5], tiempoEventos[3], proxEventos[3],
                rndEventos[6], tiempoEventos[4], proxEventos[4],
                rndEventos[7], rndEventos[8], tiempoEventos[5], proxEventos[5],
                rndEventos[9], rndEventos[10], tiempoEventos[6], proxEventos[6],
                estadoCancha, colaCancha,
                contadorBasket, contadorFutbol, contadorHandball,
                acumEsperaBasket, acumEsperaFutbol, acumEsperaHandball,
                acumOcupacion
            };

            //Armar lista de datos de clientes formateada
            foreach(object[] cliente in (List<object[]>)vector[38])
            {
                if(this.ordenDeLosClientesPorId.FindIndex(id => id==Convert.ToInt32(cliente[0])) == -1)
                {
                    this.ordenDeLosClientesPorId.Add(Convert.ToInt32(cliente[0]));
                    this.ordenDeLosClientesPorDisciplina.Add(cliente[1].ToString());
                }
            }
            List<string> datosDeClientesEnOrden = new List<string>();
            foreach (int id in this.ordenDeLosClientesPorId)
            {
                bool clienteEncontrado = false;
                foreach (object[] cliente in (List<object[]>)vector[38])
                {
                    if (id == Convert.ToInt32(cliente[0]))
                    {
                        datosDeClientesEnOrden.Add(cliente[2].ToString());
                        datosDeClientesEnOrden.Add(this.truncar((double)cliente[3], 4).ToString());
                        datosDeClientesEnOrden.Add((double)cliente[4] == 0 ? "" : this.truncar((double)cliente[4], 4).ToString());
                        clienteEncontrado = true;
                        break;
                    }
                }
                if(!clienteEncontrado)
                {
                    datosDeClientesEnOrden.Add("");
                    datosDeClientesEnOrden.Add("");
                    datosDeClientesEnOrden.Add("");
                }
            }

            //Armar un nuevo vector con ambos iterables
            string[] vectorCompleto = new string[38 + datosDeClientesEnOrden.Count];
            Array.Copy(vectorSinClientes, vectorCompleto, 38);
            for (int i = 38; i < vectorCompleto.Length; i++)
            {
                vectorCompleto[i] = datosDeClientesEnOrden[i - 38];
            }

            return vectorCompleto;
        }

        private double truncar(double num, int decimales)
        {
            double resultado = Math.Floor(num * Math.Pow(10, decimales)) / Math.Pow(10,decimales);
            return resultado;
        }

        private void chkEstadosInter_CheckedChanged(object sender, EventArgs e)
        {
            txtHoraDesde.Clear();
            txtHoraDesde.Enabled = chkEstadosInter.Checked;
            txtHoraDesde.Text = "0";

            txtIteracionesHasta.Clear();
            txtIteracionesHasta.Enabled = chkEstadosInter.Checked;
            txtIteracionesHasta.Text = txtIteraciones.Text;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMediaB.Text = (8 * 60).ToString();
            txtDesvB.Text = (2 * 60).ToString();
            txtMediaF.Text = (10 * 60).ToString();
            txtMediaH.Text = (12 * 60).ToString();
            txtDesvH.Text = (2 * 60).ToString();
            txtOMediaB.Text = "100";
            txtOAmpB.Text = "30";
            txtOMediaF.Text = "90";
            txtODesvF.Text = "10";
            txtOMediaH.Text = "80";
            txtODesvH.Text = "20";

            txtDBasket.Text = "300";
            txtDFutbol.Text = "100";
            txtDHandball.Text = "200";

            txtH.Text = "0,1";
        }

        private void txtIteraciones_TextChanged(object sender, EventArgs e)
        {
            if (!chkEstadosInter.Checked) 
            {
                txtIteracionesHasta.Text = txtIteraciones.Text;
            }

        }
    }
}
