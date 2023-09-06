using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5
{
    public partial class FormTablaIntegracion : Form
    {
        List<double?[]> valoresTabla;
        public FormTablaIntegracion(List<double?[]> procesoIntegracion)
        {
            InitializeComponent();
            this.valoresTabla = procesoIntegracion;
        }

        private void FormTablaIntegracion_Load(object sender, EventArgs e)
        {
            foreach (double?[] fila in this.valoresTabla)
            {
                string t = fila[0].ToString() ?? "";
                string D = fila[1] == null? "" : Math.Round((double)fila[1],4).ToString();
                string DPrima = fila[2] == null ? "" : Math.Round((double)fila[2], 4).ToString();
                string t_1 = fila[3].ToString() ?? "";
                string D_1 = fila[4] == null ? "" : Math.Round((double)fila[4], 4).ToString();

                string[] strFila = new string[] { t, D, DPrima, t_1, D_1 };
                dataGridView1.Rows.Add(strFila);

            }
            //Pintar fila con el resultado
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = System.Drawing.Color.LimeGreen;
        }
    }
}
