using System.Collections.Generic;

namespace task_21_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создайте класс билета (Ticket). сгенерируйте список из 30 билетов. произведите:
            //• поиск билета с максимальной суммой,
            //• билета с минимальной суммой,
            //• выведите список билетов с багажом
            //• выведите список люготных билетов

            Ticket ticket;
            List<Ticket> list = new List<Ticket>();
            for (int i = 0; i < 30; i++)
            {
                ticket = new Ticket();
                list.Add(ticket);
                ticket.Print();
            };
            Console.WriteLine();
            Console.WriteLine("Максимальная сумма: ");
            ticket = MaxSumm(list);
            ticket.Print();
            Console.WriteLine();
            Console.WriteLine("Минимальная сумма: ");
            ticket = MinSumm(list);
            ticket.Print();
            Console.WriteLine();
            Console.WriteLine("С багажом: ");
            PrintBaggaje(list);
            Console.WriteLine();
            Console.WriteLine("Льготные: ");
            PrintLgot(list);
        }
        public static Ticket MaxSumm(List<Ticket> list)
        {
            if (list == null || list.Count == 0)
            {
                return null; 
            }

            Ticket max = list[0]; 
            foreach (var ticket in list)
            {
                if (ticket.Summ > max.Summ)
                {
                    max = ticket;
                }
            }
            return max;
        }

        public static Ticket MinSumm(List<Ticket> list)
        {
            if (list == null || list.Count == 0)
            {
                return null; 
            }

            Ticket min = list[0]; 
            foreach (var ticket in list)
            {
                if (ticket.Summ < min.Summ)
                {
                    min = ticket;
                }
            }
            return min;
        }


        public static void PrintBaggaje(List<Ticket> list)
        {
            foreach (var a in list)
            {
                if (a.Baggaje)
                {
                    a.Print();
                }
            }
        }

        public static void PrintLgot(List<Ticket> list)
        {
            foreach (var a in list)
            {
                if (a.Lgot)
                {
                    a.Print();
                }
            }
        }
    }
}
