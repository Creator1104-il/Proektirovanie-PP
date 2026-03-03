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
    public partial class zadanie1 : Form
    {
        public zadanie1()
        {
            InitializeComponent();
        }

        private void zadanie1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] k = new int[10];
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


            }
            catch (Exception ) 
            {
                label2.Text = "Неверный формат";
            }

            int rez = 0;
            for (int i = 0; i < k.Length; i++)
            {
                rez += k[i];
            }

            label2.Text = rez.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
