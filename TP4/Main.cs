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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int maximo = Int32.Parse(txtMaximo.Text);
            int minimo = Int32.Parse(txtMinimo.Text);
            dgvPrimeraTirada.Rows.Clear();

            for(int i = minimo; i <= maximo; i++)
            {
                dgvPrimeraTirada.Rows.Add(new object[] { i, ""});
            }
        }

        private void btnGenerarSegunda_Click(object sender, EventArgs e)
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
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            IncrementarSimulaciones();
            int puntosStrike = Int32.Parse(txtStrike.Text);
            int puntosSpare = Int32.Parse(txtSpare.Text);
            int puntosLimite = Int32.Parse(txtThreshold.Text);
            int maximo = Int32.Parse(txtMaximo.Text);
            int minimo = Int32.Parse(txtMinimo.Text);
            int total = maximo - minimo;
            double[] probabilidades = new double[total+1];
            int i = 0;
            Dictionary<int, double[]> probabilidadXResultado = new Dictionary<int, double[]>();
            foreach (DataGridViewRow row in dgvPrimeraTirada.Rows)
            {
                int valor1 = Int32.Parse(row.Cells[0].Value.ToString());
                probabilidades[i] = Double.Parse(row.Cells[1].Value.ToString());
                i++;
                List<double> probSegunda = new List<double>();
                foreach(DataGridViewRow row2 in dgvSegundaTirada.Rows)
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
            foreach(int key in probabilidadXResultado.Keys)
            {
                double[] probs = probabilidadXResultado[key];
                PMF pmf = new PMF(0, maximo - key, probs);
                cajaTextual.AppendText(pmf.ToString());

                FuncionesDeCuantiaPorValor.Add(key, pmf);
            }
            Ejercicio24 ejercicio24 = new Ejercicio24(minimo, maximo, probabilidades, puntosStrike, puntosSpare, puntosLimite, FuncionesDeCuantiaPorValor);

            double[] ultimoVector =  ejercicio24.ComputeMontecarlo(10);
            cajaTextual.AppendText(ejercicio24.montecarlo.LastVectorToString());

            if (ejercicio24.SurpassedThreshold())
            {
                IncrementarExitos();
            }

            CalcularProbabilidadExito();
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
    }
}
