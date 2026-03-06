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
    public partial class zadanie3 : Form
    {
        public zadanie3()
        {
            InitializeComponent();
        }

        private void zadanie3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double celsius = double.Parse(textBox1.Text);
                    double fahrenheit = CelsiusToFahrenheit(celsius);
                    label1.Text = fahrenheit.ToString("0.00");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введите числовое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double fahrenheit = double.Parse(textBox1.Text);
                    double celsius = FahrenheitToCelsius(fahrenheit);
                    label1.Text = celsius.ToString("0.00");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введите числовое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private double FahrenheitToCelsius(double fahrenheit)
        {
            double k = fahrenheit - 32 / 9*5;
            return k;
        }

        private double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 1.8) + 32;
        }
    }
}
