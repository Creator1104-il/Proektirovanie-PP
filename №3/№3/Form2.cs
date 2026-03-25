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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<string> list = new List<string>();
        public int allVisitor = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Всего поситителей было " + allVisitor);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                list.Add(this.textBox1.Text);
            }catch (Exception)
            {
                MessageBox.Show("Имя пользователя не должно содержать цифры");
            } 
            allVisitor++;
            MessageBox.Show("Пользователь добавлен!");
            this.textBox1.Clear();
        }
    }
}
