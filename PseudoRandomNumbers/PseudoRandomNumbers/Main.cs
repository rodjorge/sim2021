using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PseudoRandomNumbers.clases.generadores;

namespace PseudoRandomNumbers
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            cmb_generador.SelectedIndex = 0;
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            RandomGenerator rg = CreateRandomGenerator();

            int n = Int32.Parse(msk_n.Text);
            float[] numbers = createRandomArray(n, rg);

            txta_output.AppendText(ListToString(numbers));
        }

        private LCG CreateLCG()
        {
            int seed = Int32.Parse(msk_seed.Text);
            int k = Int32.Parse(msk_k.Text);
            int g = Int32.Parse(msk_g.Text);
            int c = Int32.Parse(msk_c.Text);

            return new LCG(seed, k, g, c);
        }

        private MCG CreateMCG()
        {
            int seed = Int32.Parse(msk_seed.Text);
            int k = Int32.Parse(msk_k.Text);
            int g = Int32.Parse(msk_g.Text);

            return new MCG(seed, k, g);
        }

        private RandomGenerator CreateStandardGenerator()
        {
            int seed = Int32.Parse(msk_seed.Text);

            return new StandardGenerator(seed);
        }

        private RandomGenerator CreateRandomGenerator()
        {
            if(cmb_generador.SelectedIndex == 0)
            {
                return CreateLCG();
            }
            if(cmb_generador.SelectedIndex == 1)
            {
                return CreateMCG();
            }

            return CreateStandardGenerator();
        }

        private float[] createRandomArray(int n, RandomGenerator rg)
        {
            float[] numbers = new float[n];

            for(int i = 0; i < n; i++)
            {
                numbers[i] = rg.GetNextRandomNumber();
            }

            return numbers;
        }

        private string ListToString(IList<float> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('[');
            for(int i = 0; i < list.Count; i++)
            {
                sb.Append(Math.Round(list[i], 4));
                sb.Append(", ");
            }
            sb.Remove(sb.Length - 2, 2);
            sb.Append("]");
            sb.Append(Environment.NewLine);

            return sb.ToString();
        }
    }
}
