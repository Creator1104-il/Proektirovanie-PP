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
    public partial class zadanie2 : Form
    {
        public zadanie2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;

            if (CheckPasswordLength(password))
            {
                // Проверка наличия цифр
                if (CheckPasswordDigits(password))
                {
                    // Вывод оценки надежности
                    label1.Text = ShowPasswordStrength(password);
                }
                else
                {
                    label1.Text = "Пароль должен содержать хотя бы одну цифру";
                }
            }
            else
            {
                label1.Text = "Пароль должен быть не менее 8 символов";
            }
        }

        private bool CheckPasswordLength(string password)
        {
            return password.Length >= 8;
        }
        private bool CheckPasswordDigits(string password)
        {
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }
        private string ShowPasswordStrength(string password)
        {
            int length = password.Length;
            bool hasDigit = CheckPasswordDigits(password);

            if (length < 8)
                return "Слабый";
            else if (length >= 8 && length < 12)
                return hasDigit ? "Средний" : "Слабый";
            else
                return hasDigit ? "Надёжный" : "Средний";
        }
    }
}
