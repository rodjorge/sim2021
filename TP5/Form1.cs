using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TP5.classes;

namespace TP5
{
    public partial class Form1 : Form
    {
        GestorSimulacion simulador;
        public Form1()
        {
            InitializeComponent();
            this.simulador = new GestorSimulacion();
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
            List<object[]> resultados = this.simulador.simular(1000000, 1000000, parametros, 2000, 30);

            foreach (object[] fila in resultados) {
                dataGridView1.Rows.Add((new ArraySegment<object>(fila, 0, 30).Array));
             }
        }
    }
}
