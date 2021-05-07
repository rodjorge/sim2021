    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TP4.Classes;

namespace TP4
{
    public partial class Main : Form
    {
        private RadioButton RadioButtonElegido;
        public Main()
        {
            InitializeComponent();
            txtExitos.Text = "0";
            txtSimulaciones.Text = "0";
            txtStrike.Text = "20";
            txtSpare.Text = "15";
            txtThreshold.Text = "120";
            txtMaximo.Text = "10";
            txtMinimo.Text = "7";
            txtRounds.Text = "100";
            txtDesde.Text = "10";
            txtHasta.Text = "20";
            txtVueltas.Text = "1";
            rbtCrypto.Checked = true;
            RadioButtonElegido = rbtCrypto;
            chkDefault.Checked = true;
            AsociarEventoARadios();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvPrimeraTirada.Rows.Clear();
            dgvSegundaTirada.Rows.Clear();
            if (ValidarGenerar() && !chkDefault.Checked)
            {
                int maximo = Int32.Parse(txtMaximo.Text);
                int minimo = Int32.Parse(txtMinimo.Text);
                dgvPrimeraTirada.Rows.Clear();

                for (int i = minimo; i <= maximo; i++)
                {
                    dgvPrimeraTirada.Rows.Add(new object[] { i, "" });
                }
                return;
            }

            dgvSegundaTirada.Visible = true;
            CargarGrillasPorDefecto();
            MostrarControlesSegundaTirada();
            MostrarControlesSimulacion();
            chkVerMedio.Checked = true;
        }

        private void btnGenerarSegunda_Click(object sender, EventArgs e)
        {
            dgvSegundaTirada.Rows.Clear();
            if (ValidarGenerarSegunda() && !chkDefault.Checked)
            {
                dgvSegundaTirada.Rows.Clear();
                foreach (DataGridViewRow row in dgvPrimeraTirada.Rows)
                {
                    int maximo = Int32.Parse(txtMaximo.Text);
                    int pinos = Int32.Parse(row.Cells[0].Value.ToString());
                    int limite = maximo - pinos;

                    for (int i = 0; i <= limite; i++)
                    {
                        dgvSegundaTirada.Rows.Add(new object[] { pinos, i, "" });
                    }
                }
                dgvSegundaTirada.Visible = true;
                MostrarControlesSimulacion();
            }
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            int vueltas = 0;
            if(General.ValidarConversionInt(txtVueltas.Text))
            {
                vueltas = Int32.Parse(txtVueltas.Text);
            }
            if (ValidarSimular())
            {
                dgvResultados.Rows.Clear();

                //variables a utilizarse durante la ejecucion del metodo

                string generator = RadioButtonElegido.Text;
                int puntosStrike = Int32.Parse(txtStrike.Text);
                int puntosSpare = Int32.Parse(txtSpare.Text);
                int puntosLimite = Int32.Parse(txtThreshold.Text);
                int maximo = Int32.Parse(txtMaximo.Text);
                int minimo = Int32.Parse(txtMinimo.Text);
                int total = maximo - minimo;
                int rounds = Int32.Parse(txtRounds.Text);
                double[] probabilidades = new double[total + 1];
                Dictionary<int, double[]> probabilidadXResultado = new Dictionary<int, double[]>();
                Dictionary<int, PMF> FuncionesDeCuantiaPorValor = new Dictionary<int, PMF>();

                CargarProbabilidadXResultado(probabilidades, probabilidadXResultado, total);
                CargarFuncionesDeCuantiaXValor(FuncionesDeCuantiaPorValor, probabilidadXResultado, maximo);

                int desde = Int32.Parse(txtDesde.Text);
                int hasta = Int32.Parse(txtHasta.Text);

                int primeraVueltaAPersistir = (desde-1) / rounds;
                int ultimaVueltaAPersistir = (hasta-1) / rounds;

                double[] ultimoVector = { 0 };
                List<double[]> enIntervalo = new List<double[]>();
                bool terminaEnIntervalo = false;

                for (int vuelta = 0; vuelta < vueltas; vuelta++)
                {
                    //Al ejecutarse la simulación se suma uno al total
                    IncrementarSimulaciones();
                
                    Ejercicio24 ejercicio24 = new Ejercicio24(minimo, maximo, probabilidades, puntosStrike, puntosSpare, puntosLimite, FuncionesDeCuantiaPorValor, generator);

                    if(chkVerMedio.Checked && vuelta >= primeraVueltaAPersistir && vuelta<=ultimaVueltaAPersistir)
                    {
                        int filasDesde, filasHasta;
                        if(vuelta == primeraVueltaAPersistir)
                        {
                            filasDesde = (desde-1) % rounds+1;
                            if(vuelta != ultimaVueltaAPersistir)
                                filasHasta = rounds+1;
                            else
                                filasHasta = (hasta - 1) % rounds + 1;
                        } else if(vuelta == ultimaVueltaAPersistir)
                        {
                            filasDesde = 1;
                            filasHasta = (hasta - 1) % rounds + 1;
                        } else
                        {
                            filasDesde = 1;
                            filasHasta = rounds + 1;
                        }

                        enIntervalo = ejercicio24.ComputeMontecarlo(rounds, filasDesde, filasHasta);
                        foreach(double[] vector in enIntervalo)
                        {
                            vector[0] += vuelta * rounds;
                            insertarArrayEnDGV(vector, dgvResultados);
                        }

                        if (vuelta == vueltas - 1 && filasHasta-1 == rounds)
                            terminaEnIntervalo = true;
                    }
                    else
                    {
                        ejercicio24.ComputeMontecarlo(rounds);
                    }
                    if (ejercicio24.SurpassedThreshold())
                    {
                        IncrementarExitos();
                    }
                    ultimoVector = ejercicio24.getLastVector();
                }
                if (!terminaEnIntervalo)
                {
                    ultimoVector[0] += (vueltas - 1) * rounds;
                    insertarArrayEnDGV(ultimoVector, dgvResultados);
                }

                CalcularProbabilidadExito();
            }
        }

        private void CargarProbabilidadXResultado(double[] probabilidades, Dictionary<int, double[]> probabilidadXResultado, int total)
        {
            List<double> probSegunda = new List<double>();
            int kAccum = 0;
            for(int i = 0; i <= total; i++) 
            {
                int valor = Int32.Parse(dgvPrimeraTirada[0, i].Value.ToString());
                probabilidades[i] = Double.Parse(dgvPrimeraTirada[1, i].Value.ToString());
                // k es la cantidad de posibles sucesos que quedan, en el caso de haber tirado 7 pinos
                // quedan las posibilidades 0 , 1 , 2 y 3 (Osea 4)
                int k = (11 - valor);
                for(int j = 1; j <= k; j++)
                {
                    double prob = Double.Parse(dgvSegundaTirada[2, j + (kAccum -1)].Value.ToString());
                    probSegunda.Add(prob);
                }
                probabilidadXResultado.Add(valor, probSegunda.ToArray());
                probSegunda.Clear();
                kAccum += k;
            }
        }

        private void CargarFuncionesDeCuantiaXValor(Dictionary<int, PMF> cuantiaXValor, Dictionary<int, double[]> probabilidadXResultado, int maximo)
        {
            foreach (int key in probabilidadXResultado.Keys)
            {
                double[] probs = probabilidadXResultado[key];
                PMF pmf = new PMF(0, maximo - key, probs);
                //cajaTextual.AppendText(pmf.ToString());

                cuantiaXValor.Add(key, pmf);
            }
        }
        private bool ValidarSimular()
        {
            // Validacion del valor de strike
            if(!Int32.TryParse(txtStrike.Text, out int strike))
            {
                MessageBox.Show("El puntaje de strike debe ser un numero entero", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(strike < 0)
            {
                MessageBox.Show("El puntaje de strike debe ser positivo", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Validacion del valor de spare
            if (!Int32.TryParse(txtSpare.Text, out int spare))
            {
                MessageBox.Show("El puntaje de spare debe ser un numero entero", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (spare < 0)
            {
                MessageBox.Show("El puntaje de spare debe ser positivo", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Validacion del valor de threshold
            if (!Int32.TryParse(txtThreshold.Text, out int threshold))
            {
                MessageBox.Show("El puntaje threshold debe ser un numero entero", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (threshold < 0)
            {
                MessageBox.Show("El puntaje threshold debe ser positivo", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validacion de la cantidad de rounds
            if (!Int32.TryParse(txtRounds.Text, out int rounds))
            {
                MessageBox.Show("La cantidad de rounds debe ser un numero entero", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (rounds < 0)
            {
                MessageBox.Show("La cantidad de rounds debe ser positiva", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validacion de la cantidad de partidas
            if (!Int32.TryParse(txtVueltas.Text, out int vueltas))
            {
                MessageBox.Show("La cantidad de partidas debe ser un numero entero", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (vueltas < 1)
            {
                MessageBox.Show("La cantidad de partidas debe ser mayor o igual a 1", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validacion valor fila desde
            if (!Int32.TryParse(txtDesde.Text, out int desde))
            {
                MessageBox.Show("El valor de desde debe ser un numero entero", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (desde < 1)
            {
                MessageBox.Show("El valor de desde debe ser mayor o igual a 1", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validacion valor fila hasta
            if (!Int32.TryParse(txtHasta.Text, out int hasta))
            {
                MessageBox.Show("El valor de hasta debe ser un numero entero", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (hasta < desde)
            {
                MessageBox.Show("El valor de hasta debe ser mayor o igual al de desde", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return validarCeldasDGV(dgvSegundaTirada, 2);
        }

        private void IncrementarExitos()
        {
            txtExitos.Text = (Int32.Parse(txtExitos.Text) + 1).ToString();
        }

        private void IncrementarSimulaciones()
        {
            txtSimulaciones.Text = (Int32.Parse(txtSimulaciones.Text) + 1).ToString();
        }

        private void CalcularProbabilidadExito()
        {
            int exitos = Int32.Parse(txtExitos.Text);
            int simulaciones = Int32.Parse(txtSimulaciones.Text);
            double probabilidad = (double)exitos / simulaciones;
            nroExito.Text = General.TruncateDecimal(probabilidad, 3).ToString();
        }

        private void insertarArrayEnDGV(IList<double> list, DataGridView dgv)
        {
            int rowCount = dgv.Rows.Count;
            int colCount = dgv.Columns.Count;
            dgv.Rows.Add();
            for(int i = 0; i< colCount; i++)
            {
                dgv[i, rowCount].Value = list[i];
            }
        }

        private bool ValidarGenerar()
        {
            try
            {
                int maximo = Int32.Parse(txtMaximo.Text);
                int minimo = Int32.Parse(txtMinimo.Text);
                if(maximo < minimo)
                {
                    MessageBox.Show("El minimo no puede ser mayor que el maximo");
                    return false;
                }
                if(maximo < 0 || minimo < 0)
                {
                    MessageBox.Show("No se permiten valores negativos para los limites");
                    return false;
                }
                MostrarControlesSegundaTirada();
                return true;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show("Ingrese los valores maximos y minimos");
            }
            catch (FormatException e)
            {
                MessageBox.Show("Ingrese los valores en un formato valido");
            }
            return false;
        }

        private bool ValidarGenerarSegunda()
        {
            return validarCeldasDGV(dgvPrimeraTirada, 1);
        }

        private bool validarCeldasDGV(DataGridView dgv, int indiceProbabilidades)
        {
            DataGridViewRowCollection rows = dgv.Rows;
            int index = indiceProbabilidades;
            double accum = 0;
            foreach (DataGridViewRow row in rows)
            {
                if(accum != 0 && row.Cells[index-1].Value.ToString() == "0") 
                {
                    if (!ValidarAcumulador(accum))
                    {
                        break;
                    }
                    accum = 0;
                }

                string value = row.Cells[index].Value.ToString();

                bool stringCheck = row.Cells[index] is null || value.Trim() == " " || value == "";
                bool conversionCheck = General.ValidarConversionDouble(value);
                if (stringCheck || !conversionCheck) return false;

                accum += Double.Parse(value);
            }
            
            return ValidarAcumulador(accum);
        }

        private bool ValidarAcumulador(double acumulador)
        {
            if(acumulador != 1)
            {
                MessageBox.Show("La suma de las probabilidades debe ser igual a uno");
            }

            return acumulador == 1;
        }


        private void MostrarControlesSegundaTirada()
        {
            dgvPrimeraTirada.Visible = true;
            btnGenerarSegunda.Visible = true;
            lblSegundaTirada.Visible = true;
        }
        private void MostrarControlesSimulacion()
        {
            lblStrike.Visible = true;
            lblSpare.Visible = true;
            lblThreshold.Visible = true;
            lblSimulaciones.Visible = true;
            lblExitos.Visible = true;
            lblVueltas.Visible = true;
            lblRounds.Visible = true;
            txtStrike.Visible = true;
            txtSpare.Visible = true;
            txtThreshold.Visible = true;
            txtSimulaciones.Visible = true;
            txtExitos.Visible = true;
            txtVueltas.Visible = true;
            txtRounds.Visible = true;
            lblProbabilidadExito.Visible = true;
            nroExito.Visible = true;
            btnSimular.Visible = true;
            dgvResultados.Visible = true;
            chkVerMedio.Visible = true;
            gbxGeneradores.Visible = true;
        }

        private void dgvPrimeraTirada_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            DataGridView dgv = (DataGridView)sender;
            ValidarValorCelda(col, row, dgv);
        }

        private void ValidarValorCelda(int col, int row, DataGridView dgv)
        {
            if (col >= 0 && row >= 0)
            {
                string value = dgv[col, row].Value.ToString();
                if (General.ValidarConversionDouble(value))
                {
                    double num = Double.Parse(value);
                    if (num < 100 && num > 1)
                    {
                        dgv[col, row].Value = (num / 100);
                        return;
                    }
                }
            }
        }

        private void dgvSegundaTirada_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            DataGridView dgv = (DataGridView)sender;
            ValidarValorCelda(col, row, dgv);
        }

        private void CargarGrillasPorDefecto()
        {
            //Llenado de la tabla de probabilidad de la primera tirada
            this.dgvPrimeraTirada.Rows.Add(7, 0.12);
            this.dgvPrimeraTirada.Rows.Add(8, 0.15);
            this.dgvPrimeraTirada.Rows.Add(9, 0.18);
            this.dgvPrimeraTirada.Rows.Add(10, 0.55);

            //LLenado de la tabla de probabilidad de la segunda tirada
            this.dgvSegundaTirada.Rows.Add(7, 0, 0.02);
            this.dgvSegundaTirada.Rows.Add(7, 1, 0.10);
            this.dgvSegundaTirada.Rows.Add(7, 2, 0.45);
            this.dgvSegundaTirada.Rows.Add(7, 3, 0.43);
            this.dgvSegundaTirada.Rows.Add(8, 0, 0.04);
            this.dgvSegundaTirada.Rows.Add(8, 1, 0.20);
            this.dgvSegundaTirada.Rows.Add(8, 2, 0.76);
            this.dgvSegundaTirada.Rows.Add(9, 0, 0.06);
            this.dgvSegundaTirada.Rows.Add(9, 1, 0.94);
            this.dgvSegundaTirada.Rows.Add(10, 0, 1);
        }

        private void chkDefault_CheckedChanged(object sender, EventArgs e)
        {
            btnGenerarSegunda.Enabled = !btnGenerarSegunda.Enabled;
            txtMaximo.Enabled = !txtMaximo.Enabled;
            txtMinimo.Enabled = !txtMinimo.Enabled;
        }

        private void chkVerMedio_CheckedChanged(object sender, EventArgs e)
        {
            lblDesde.Visible = !lblDesde.Visible;
            lblHasta.Visible = !lblHasta.Visible;
            txtDesde.Visible = !txtDesde.Visible;
            txtHasta.Visible = !txtHasta.Visible;
        }

        private void gbxGeneradores_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbt = (RadioButton)sender;
            if (rbt.Checked)
            {
                RadioButtonElegido = (RadioButton)sender;
            }
        }

        private void AsociarEventoARadios()
        {
            foreach(Control control in gbxGeneradores.Controls)
            {
                RadioButton rbt = (RadioButton)control;
                rbt.CheckedChanged += new System.EventHandler(gbxGeneradores_CheckedChanged);
            }
        }
    }
}

