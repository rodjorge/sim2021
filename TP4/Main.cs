using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4.Classes;

namespace TP4
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            txtExitos.Text = "0";
            txtSimulaciones.Text = "0";
            txtStrike.Text = "20";
            txtSpare.Text = "15";
            txtThreshold.Text = "120";
        }
        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (ValidarSimular())
            {
                IncrementarSimulaciones();
                int puntosStrike = Int32.Parse(txtStrike.Text);
                int puntosSpare = Int32.Parse(txtSpare.Text);
                int puntosLimite = Int32.Parse(txtThreshold.Text);
                int total = 10 - 7;
                double[] probabilidades = new double[total + 1];
                int i = 0;
                Dictionary<int, double[]> probabilidadXResultado = new Dictionary<int, double[]>();
                foreach (DataGridViewRow row in dgvPrimeraTirada.Rows)
                {
                    int valor1 = Int32.Parse(row.Cells[0].Value.ToString());
                    probabilidades[i] = Double.Parse(row.Cells[1].Value.ToString());
                    i++;
                    List<double> probSegunda = new List<double>();
                    foreach (DataGridViewRow row2 in dgvSegundaTirada.Rows)
                    {
                        int valor2 = Int32.Parse(row2.Cells[0].Value.ToString());
                        if (valor2 == valor1)
                        {
                            double prob = Double.Parse(row2.Cells[2].Value.ToString());
                            probSegunda.Add(prob);
                        }
                    }
                    probabilidadXResultado.Add(valor1, probSegunda.ToArray());
                }

                Dictionary<int, PMF> FuncionesDeCuantiaPorValor = new Dictionary<int, PMF>();
                foreach (int key in probabilidadXResultado.Keys)
                {
                    double[] probs = probabilidadXResultado[key];
                    PMF pmf = new PMF(0, 10 - key, probs);
                    cajaTextual.AppendText(pmf.ToString());

                    FuncionesDeCuantiaPorValor.Add(key, pmf);
                }
                Ejercicio24 ejercicio24 = new Ejercicio24(7, 10, probabilidades, puntosStrike, puntosSpare, puntosLimite, FuncionesDeCuantiaPorValor);

                double[] ultimoVector = ejercicio24.ComputeMontecarlo(10);
                cajaTextual.AppendText(ejercicio24.montecarlo.LastVectorToString());

                if (ejercicio24.SurpassedThreshold())
                {
                    IncrementarExitos();
                }

                CalcularProbabilidadExito();
            }
        }

        private bool ValidarSimular()
        {
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
                bool conversionCheck = ValidarConversionDouble(value);
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
        private bool ValidarConversionDouble(string value)
        {
            try
            {
                double test = Double.Parse(value);
                return true;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message);
            }
            catch(FormatException e)
            {
                MessageBox.Show("Error de forma, ingrese un valor valido, ingresado: " + value);
            }
            return false;
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
                if (ValidarConversionDouble(value))
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

        private void Main_Load(object sender, EventArgs e)
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
            this.dgvSegundaTirada.Rows.Add(9, 0, 0.94);
        }
    }
}
