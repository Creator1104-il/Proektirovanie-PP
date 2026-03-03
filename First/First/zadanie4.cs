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
    public partial class zadanie4 : Form
    {
        public zadanie4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] k = new int[5];
            try
            {
                k[0] = Convert.ToInt32(textBox1.Text);
                k[1] = Convert.ToInt32(textBox2.Text);
                k[2] = Convert.ToInt32(textBox3.Text);
                k[3] = Convert.ToInt32(textBox4.Text);
                k[4] = Convert.ToInt32(textBox5.Text);
            }catch(Exception)
            {
                label2.Text = "Неверный формат!";
            }
            for(int i = 0; i < k.Length; i++)
            {
                label2.Text += k[i];
            }
            int[] n = k.Reverse().ToArray();
            for(int i = 0; i < n.Length;i++)
            {
                label3.Text += n[i];
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
