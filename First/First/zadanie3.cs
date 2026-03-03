using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First
{
    public partial class zadanie3 : Form
    {
        public zadanie3()
        {
            InitializeComponent();
        }

        private void zadanie3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] k = new int[15];
            int c = 0;
            int n = 0;
            for (int i = 0; i < k.Length; i++)
            {
                k[i] = rnd.Next(10, 51);
                foreach (int j in k)
                {
                    if (j % 2 == 0)
                    {
                        c++;
                    }
                    else
                    {
                        n++;
                    }
                }
            }
            label1.Text = "В массиве чётных чисел: " + c;
            label2.Text = "В массиве нечётных чисел: " + n;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
