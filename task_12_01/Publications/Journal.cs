using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_12_01.Publications
{
    public class Journal
    {
        public DateTime date;
        public string tema;
        public string title;
        public int countOfStr;
        public double price;

        public void Buy()
        {
            Console.WriteLine($"Журнал {title} продан");
        }

        public void View()
        {
            Console.WriteLine($"Cодержание журнала {title}:");
            Console.WriteLine(tema + "\t" + countOfStr);
        }
    }
}
