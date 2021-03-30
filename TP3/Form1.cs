using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion_tp3
{
    public partial class Form1 : Form
    {
        private List<double> variablesGeneradas;
        private GeneradorVariables generador;
        private Distribucion distribucion;
        private List<Intervalo> intervalos;
        private int tamanioMuestra;

        public Form1()
        {
            InitializeComponent();
            graficoHistograma.Titles.Add("Histograma de Frecuencias");
            graficoHistograma.ChartAreas[0].AxisX.Title = "Intervalos";
            graficoHistograma.ChartAreas[0].AxisY.Title = "Frecuencia de variables";
            graficoHistograma.Series[0].LegendText = "Fo";
            graficoHistograma.Series[1].LegendText = "Fe";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbIntervalos.SelectedIndex = 0;
        }

        private void refrescarTablaVariables()
        {
            dtgVariables.Rows.Clear();

            for (int i = 0; i < this.variablesGeneradas.Count; i++)
            {
                dtgVariables.Rows.Add(i + 1, this.variablesGeneradas[i]);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSemilla.Text))
                this.generador = new GeneradorVariables();
            else
                this.generador = new GeneradorVariables(Convert.ToInt32(txtSemilla.Text));

            this.tamanioMuestra = Convert.ToInt32(txtTamanio.Text);

            if (radUniforme.Checked)
            {
                double limInf = Convert.ToDouble(txtLimInf.Text);
                double limSup = Convert.ToDouble(txtLimSup.Text);

                this.variablesGeneradas = generador.generarListaVariablesUniformes(limInf, limSup, this.tamanioMuestra);
                this.distribucion = new DistribucionUniforme(limSup, limInf);
            }
            else if (radExponencial.Checked)
            {
                double lambda = Convert.ToDouble(txtLambda.Text);

                this.variablesGeneradas = generador.generarListaVariablesExponenciales(lambda, this.tamanioMuestra);
                this.distribucion = new DistribucionExponencial(lambda);
            }

            else if (radNormal.Checked)
            {
                double media = Convert.ToDouble(txtMedia.Text);
                double desviacion = Convert.ToDouble(txtDesviacion.Text);

                this.variablesGeneradas = generador.generarListaVariablesNormales(media, desviacion, this.tamanioMuestra);
                this.distribucion = new DistribucionNormal(media, desviacion);
            }

            this.refrescarTablaVariables();
        }

        private void btnHistograma_Click(object sender, EventArgs e)
        {
            this.intervalos = new List<Intervalo>();
            double minimo = this.variablesGeneradas.Min();
            double maximo = this.variablesGeneradas.Max() + 0.0001;
            double anchoMuestra = maximo - minimo;
            int cantIntervalos = Convert.ToInt32(cmbIntervalos.SelectedItem);
            double anchoIntervalos = anchoMuestra / cantIntervalos;

            //Creacion intervalos
            for (int i = 0; i < cantIntervalos; i++)
            {
                this.intervalos.Add(new Intervalo(minimo + anchoIntervalos * i, minimo + anchoIntervalos * (i + 1), this.distribucion));
            }

            //Conteo de frecuencia observada
            foreach (var variable in this.variablesGeneradas)
            {
                foreach (var intervalo in this.intervalos)
                {
                    if (intervalo.LimInf <= variable && variable < intervalo.LimSup)
                    {
                        intervalo.Fo = intervalo.Fo + 1;
                        break;
                    }
                }
            }

            //Llenado de tabla
            double acumC = 0;
            double c;
            dtgHistograma.Rows.Clear();
            foreach (var intervalo in this.intervalos)
            {
                c = intervalo.calcularC(this.tamanioMuestra);
                acumC += c;
                dtgHistograma.Rows.Add(Math.Round(intervalo.LimInf, 4), Math.Round(intervalo.LimSup, 4), intervalo.Fo, intervalo.calcularFe(this.tamanioMuestra), c, acumC);
            }

            //Calculo grados libertad
            int gradosLibertad = cantIntervalos - 1;
            lblGradosLibertad.Text = "GRADOS LIBERTAD: " + gradosLibertad.ToString();

            //Generacion grafico
            btnFe.Visible = true;
            graficoHistograma.Visible = true;
            List<string> etiquetasEjeX = new List<string>();
            List<double> fo = new List<double>();
            List<double> fe = new List<double>();

            foreach (var intervalo in this.intervalos)
            {
                etiquetasEjeX.Add(Math.Round(intervalo.LimInf, 4).ToString() + "-" + Math.Round(intervalo.LimSup, 4).ToString());
                fo.Add(intervalo.Fo);
                fe.Add(intervalo.calcularFe(tamanioMuestra));
            }

            graficoHistograma.Series[0].Points.DataBindXY(etiquetasEjeX, fo);
            graficoHistograma.Series[1].Points.DataBindY(fe);
            graficoHistograma.Series[0]["PointWidth"] = "1";
            graficoHistograma.Series[1]["PointWidth"] = "1";

            graficoHistograma.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            graficoHistograma.Series[1].Enabled = false;
        }

        private void btnFe_Click(object sender, EventArgs e)
        {
            graficoHistograma.Series[1].Enabled = !graficoHistograma.Series[1].Enabled;
        }
    }
}
