using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form = new zadanie1();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new zadanie2();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new zadanie3();
            form.ShowDialog();
        }
    }
}
