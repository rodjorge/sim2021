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
            this.cambioDistribucion(sender, e);
        }

        private void refrescarTablaVariables()
        {
            dtgVariables.Rows.Clear();

            for (int i = 0; i < this.variablesGeneradas.Count; i++)
            {
                dtgVariables.Rows.Add(i + 1, this.variablesGeneradas[i]);
            }
        }

        private bool validarParametros()
        {
            DialogResult errorValidacion = DialogResult.Cancel;
            if (radUniforme.Checked)
            {
                if (String.IsNullOrWhiteSpace(txtLimInf.Text) || String.IsNullOrWhiteSpace(txtLimSup.Text))
                    errorValidacion = MessageBox.Show("Los limites inferior y superior no pueden quedar vacios", "Error de parametros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (! (Double.TryParse(txtLimInf.Text, out double inf) && Double.TryParse(txtLimSup.Text, out double sup)))
                    errorValidacion = MessageBox.Show("Los limites inferior y superior deben ser numeros", "Error de parametros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (inf >= sup)
                    errorValidacion = MessageBox.Show("El limite inferior no puede ser mayor o igual al limite superior", "Error de parametros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radExponencial.Checked || radPoisson.Checked)
            {
                if (String.IsNullOrWhiteSpace(txtLambda.Text))
                    errorValidacion = MessageBox.Show("Lambda no puede quedar vacio", "Error de parametros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (! Double.TryParse(txtLambda.Text, out double lambda))
                    errorValidacion = MessageBox.Show("Lambda debe ser un numero", "Error de parametros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (lambda <= 0)
                    errorValidacion = MessageBox.Show("Lambda debe ser positivo", "Error de parametros", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (radNormal.Checked)
            {
                if (String.IsNullOrWhiteSpace(txtMedia.Text) || String.IsNullOrWhiteSpace(txtDesviacion.Text))
                    errorValidacion = MessageBox.Show("La media y la desviación no pueden quedar vacias", "Error de parametros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (!(Double.TryParse(txtMedia.Text, out double media) && Double.TryParse(txtDesviacion.Text, out double desviacion)))
                    errorValidacion = MessageBox.Show("La media y la desviación deben ser numeros", "Error de parametros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (desviacion <= 0)
                    errorValidacion = MessageBox.Show("La desviación debe ser positiva", "Error de parametros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (String.IsNullOrWhiteSpace(txtTamanio.Text))
                errorValidacion = MessageBox.Show("El tamaño de la muestra no puede quedar vacio", "Error de parametros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!Int32.TryParse(txtTamanio.Text, out int tamanio))
                errorValidacion = MessageBox.Show("El tamaño de la muestra debe ser un numero entero", "Error de parametros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tamanio <= 0)
                errorValidacion = MessageBox.Show("El tamaño de la muestra debe ser positivo", "Error de parametros", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (errorValidacion == DialogResult.OK)
                return false;
            return true;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!this.validarParametros())
                return;

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
            else if (radPoisson.Checked)
            {
                double lambda = Convert.ToDouble(txtLambda.Text);

                this.variablesGeneradas = this.generador.generarListaVariablesPoisson(lambda, this.tamanioMuestra);
                this.distribucion = new DistribucionPoisson(lambda);
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

            if (distribucion.esDiscreta())
                anchoIntervalos = Math.Ceiling(anchoIntervalos);

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

        private void cambioDistribucion(object sender, EventArgs e)
        {
            if (radUniforme.Checked)
            {
                txtLimInf.Enabled = true;
                txtLimSup.Enabled = true;

                txtMedia.Enabled = false;
                txtDesviacion.Enabled = false;
                txtLambda.Enabled = false;

                this.limpiarCampos();
            }
            else if (radExponencial.Checked || radPoisson.Checked)
            {
                txtLambda.Enabled = true;
                txtMedia.Enabled = true;

                txtDesviacion.Enabled = false;
                txtLimInf.Enabled = false;
                txtLimSup.Enabled = false;

                this.limpiarCampos();
            }
            else if (radNormal.Checked)
            {
                txtMedia.Enabled = true;
                txtDesviacion.Enabled = true;

                txtLimInf.Enabled = false;
                txtLimSup.Enabled = false;
                txtLambda.Enabled = false;

                this.limpiarCampos();
            }
        }

        private void limpiarCampos()
        {
            txtLimInf.Text = "";
            txtLimSup.Text = "";
            txtMedia.Text = "";
            txtDesviacion.Text = "";
            txtLambda.Text = "";
        }

        private void txtLambda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMedia_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(txtMedia.Text, out double media))
            {
                if (radExponencial.Checked)
                {
                    txtLambda.Text = Math.Round(1.0 / media, 4).ToString();
                }
                else if (radPoisson.Checked)
                {
                    txtLambda.Text = media.ToString();
                }
            }

            if (String.IsNullOrEmpty(txtMedia.Text))
                txtLambda.Text = "";
        }

        private void bgWorkerGenerador_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
