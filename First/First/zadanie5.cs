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
    public partial class zadanie5 : Form
    {
        public zadanie5()
        {
            InitializeComponent();
        }

        private void zadanie5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const int n = 5;
            int[] a = new int[5];
            try
            {
                a[0] = Convert.ToInt32(textBox2.Text);
                a[1] = Convert.ToInt32(textBox3.Text);
                a[2] = Convert.ToInt32(textBox4.Text);
                a[3] = Convert.ToInt32(textBox5.Text);
                a[4] = Convert.ToInt32(textBox6.Text);
            }catch (Exception)
            {
                label1.Text = "Error";
            } 
            for(int i = 0; i < n; i++)
            {
                label1.Text += a[i];
            }
            int k = Convert.ToInt32(textBox1.Text);

            int la = a[a.Length - 1];
            for (int i = 0; i < k; ++i)
            {
                int aLast = a[n - 1];
                for (int j = n - 1; j > 0; j--)
                    a[j] = a[j - 1];
                a[0] = aLast;
            }
            //a[0] = la;
            for (int i = 0; i < n; ++i)
                label2.Text += a[i];
        }
    }
}
