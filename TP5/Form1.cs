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
            double[][] parametros = new double[][] {
                new double[] { 10 },
                new double[] { 8*60, 2*60 },
                new double[] { 10*60 },
                new double[] { 12*60, 2*60 },
                new double[] { 100, 30 },
                new double[] { 90, 10 },
                new double[] { 80, 20 },
            };
            List<object[]> resultados = this.simulador.simular(1000, 20, parametros, 0, 20);

            //Formateo de resultados
            List<string[]> resFormateados = new List<string[]>();
            foreach (object[] fila in resultados) {
                resFormateados.Add(this.armarFila(fila));
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
        }

        private string[] armarFila(object[] vector)
        {
            string evento = (string)vector[0];
            string reloj = this.truncar((double)vector[1], 4).ToString();
            string finAcond = String.IsNullOrEmpty((string)vector[2]) ? (string)vector[2] : this.truncar(Convert.ToDouble(vector[2]), 4).ToString();
            List<string> rndEventos = new List<string>();
            List<string> tiempoEventos = new List<string>();
            List<string> proxEventos = new List<string>();
            for (int i = 3; i < 21; i+=3)
            {
                rndEventos.Add(String.IsNullOrEmpty((string)vector[i]) ? (string)vector[i] : this.truncar(Convert.ToDouble(vector[i]), 4).ToString());
                tiempoEventos.Add(String.IsNullOrEmpty((string)vector[i+1]) ? (string)vector[i+1] : this.truncar(Convert.ToDouble(vector[i+1]), 4).ToString());
                proxEventos.Add(String.IsNullOrEmpty((string)vector[i+2]) ? (string)vector[i+2] : this.truncar(Convert.ToDouble(vector[i+2]), 4).ToString());
            }
            string estadoCancha = (string)vector[21];
            string colaCancha = vector[22].ToString();
            string contadorBasket = vector[23].ToString();
            string contadorFutbol = vector[24].ToString();
            string contadorHandball = vector[25].ToString();
            string acumEsperaBasket = String.IsNullOrEmpty(vector[26].ToString()) ? (string)vector[26] : this.truncar(Convert.ToDouble(vector[26]), 4).ToString();
            string acumEsperaFutbol = String.IsNullOrEmpty(vector[27].ToString()) ? (string)vector[27] : this.truncar(Convert.ToDouble(vector[27]), 4).ToString();
            string acumEsperaHandball = String.IsNullOrEmpty(vector[28].ToString()) ? (string)vector[28] : this.truncar(Convert.ToDouble(vector[28]), 4).ToString();
            string acumOcupacion = String.IsNullOrEmpty(vector[29].ToString()) ? (string)vector[29] : this.truncar(Convert.ToDouble(vector[29]), 4).ToString();

            string[] vectorSinClientes = new string[]
            {
                evento, reloj, finAcond,
                rndEventos[0], tiempoEventos[0], proxEventos[0],
                rndEventos[1], tiempoEventos[1], proxEventos[1],
                rndEventos[2], tiempoEventos[2], proxEventos[2],
                rndEventos[3], tiempoEventos[3], proxEventos[3],
                rndEventos[4], tiempoEventos[4], proxEventos[4],
                rndEventos[5], tiempoEventos[5], proxEventos[5],
                estadoCancha, colaCancha,
                contadorBasket, contadorFutbol, contadorHandball,
                acumEsperaBasket, acumEsperaFutbol, acumEsperaHandball,
                acumOcupacion
            };

            //Armar lista de datos de clientes formateada
            foreach(object[] cliente in (List<object[]>)vector[30])
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
                foreach (object[] cliente in (List<object[]>)vector[30])
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
            string[] vectorCompleto = new string[30 + datosDeClientesEnOrden.Count];
            Array.Copy(vectorSinClientes, vectorCompleto, 30);
            for (int i = 30; i < vectorCompleto.Length; i++)
            {
                vectorCompleto[i] = datosDeClientesEnOrden[i - 30];
            }

            return vectorCompleto;
        }

        private double truncar(double num, int decimales)
        {
            double resultado = Math.Floor(num * Math.Pow(10, decimales)) / Math.Pow(10,decimales);
            return resultado;
        }
    }
}
