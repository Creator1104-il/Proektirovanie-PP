using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First
{
    public partial class zadanie2 : Form
    {
        public zadanie2()
        {
            InitializeComponent();
        }

        private void zadanie2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int l = Convert.ToInt32(textBox1.Text);
            int[] k = new int[l];
            Random random = new Random();
            for (int i = 0; i < l; i++)
            {
                
               k[i] = random.Next(1, 101);
            }

            int max = k.Max();
            int min = k.Min();

            label2.Text = "Максимальное значение в массиве " + max;
            label3.Text = "Минимальное значение в массиве " + min;


        }
    }
}
