using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_12_01.Publications
{
    public class Newspaper
    {
        public DateTime date;
        public string title;
        public string heading;
        public int countOfStr;
        public double price;

        public void GetInformation()
        {
            Console.WriteLine($"Дата издания газеты - {date}");
            Console.WriteLine($"Название газеты - {title}");
            Console.WriteLine($"Заголовок главной полосы - {heading}");
            Console.WriteLine($"Количество страниц - {countOfStr}");
            Console.WriteLine($"Цена - {price}");
        }
        public void ToTakeTheFlourFactory()
        {
            if (countOfStr > 10)
            {
                Console.WriteLine("Следует сдать в мукалатуру");
            }
            else
                Console.WriteLine("Мукалатуру не нужно сдавать");
        }
     }
}
