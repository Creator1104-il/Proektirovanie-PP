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
    public partial class zadanie1 : Form
    {
        public zadanie1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double sum = Convert.ToDouble(textBox1.Text);

                double discount = CalculateDiscount(sum);
                double finalAmount = sum - (sum * discount / 100);

                label1.Text = $"Итоговая сумма: {finalAmount:F2} руб.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное число через запятую!");
            }

        }
        private double CalculateDiscount(double sum)
        {
            if (sum <= 1000)
                return 0;
            else if (sum <= 5000)
                return 5;
            else
                return 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
