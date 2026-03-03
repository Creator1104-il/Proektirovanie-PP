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
    public partial class Form1 : Form
    {
        int rez;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new zadanie1();
            form.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form form = new zadanie2();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new zadanie3();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new zadanie4();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new zadanie5();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new zadanie6();
            form.ShowDialog();
        }
    }
}
