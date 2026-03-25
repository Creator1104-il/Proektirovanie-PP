using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book myBook = new Book();

            try
            {
                myBook.title = textBox1.Text;
                myBook.author = textBox2.Text;
                myBook.year = Convert.ToInt32(textBox3.Text);
            }catch(Exception)
            {
                MessageBox.Show("Год написания книги должен быть числом!");
            }
            myBook.GetInfo();

            Book unknownBook = new Book();

            // Вызываем метод для второго объекта
            unknownBook.GetInfo();

            //MessageBox.Show($"Вторая книга (по умолчанию):\n«{unknownBook.title}», {unknownBook.author} ({unknownBook.year})");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.ShowDialog();
        }
    }
}
