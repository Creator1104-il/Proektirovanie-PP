using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
        
    public class Book
    {
        public string title = "Неизвестно";
        public string author = "Неизвестно";
        public int year;

        public void GetInfo()
        {
            MessageBox.Show($"«{title}», {author} ({year})");
        }


    }
}
