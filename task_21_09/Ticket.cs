using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task_21_09
{
    internal class Ticket
    {
        public int Summ {get; set;}
        public bool Baggaje {get; set;}
        public bool Lgot {get; set;}

        public Ticket()
        {
            Random random = new Random();
            Summ = random.Next(100, 200);
            int a = random.Next(0, 2);
            if (a == 0)
            {
                Baggaje = false;
            }
            else
            {
                Baggaje = true;
            }
            int b = random.Next(0, 2);
            if (b == 0)
            {
                Lgot = false;
            }
            else
            {
                Lgot = true;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Сумма: {Summ} \tБагаж: {Baggaje} \tЛьготный бимлет: {Lgot}");
        }
    }
}
