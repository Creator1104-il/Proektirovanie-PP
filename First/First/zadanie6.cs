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
    public partial class zadanie6 : Form
    {
        public zadanie6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] k = new int[10];
            int[] f = new int[10];
            try
            {
                k[0] = Convert.ToInt32(textBox1.Text);
                k[1] = Convert.ToInt32(textBox2.Text);
                k[2] = Convert.ToInt32(textBox3.Text);
                k[3] = Convert.ToInt32(textBox4.Text);
                k[4] = Convert.ToInt32(textBox5.Text);
                k[5] = Convert.ToInt32(textBox6.Text);
                k[6] = Convert.ToInt32(textBox7.Text);
                k[7] = Convert.ToInt32(textBox8.Text);
                k[8] = Convert.ToInt32(textBox9.Text);
                k[9] = Convert.ToInt32(textBox10.Text);

                //f[0] = Convert.ToInt32(textBox1.Text);
                //f[1] = Convert.ToInt32(textBox2.Text);
                //f[2] = Convert.ToInt32(textBox3.Text);
                //f[3] = Convert.ToInt32(textBox4.Text);
                //f[4] = Convert.ToInt32(textBox5.Text);
                //f[5] = Convert.ToInt32(textBox6.Text);
                //f[6] = Convert.ToInt32(textBox7.Text);
                //f[7] = Convert.ToInt32(textBox8.Text);
                //f[8] = Convert.ToInt32(textBox9.Text);
                //f[9] = Convert.ToInt32(textBox10.Text);
            }
            catch (Exception)
            {
                label1.Text = "Неверный формат";
            }
            int cont = 0;
            int j = 0;
            for(int i =  0; i < 9; i++)
            {
                if (k[i] == k[i + 1])
                {
                    cont++;                    
                    j = i+1;
                }
                
            }
            if (j == 0)
            {
                label1.Text = "Нет повторяющихся чисел";
            }
            else
            {
                label1.Text = "Число " +cont  + " встречается " + j + " раз";
            }
        }
    }
}
