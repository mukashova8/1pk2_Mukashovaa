﻿namespace task_03__05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
            //Фаренгейта(F = C * 1, 8 + 32).Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
            //время работы программы

            double f;
            Console.WriteLine("температура 1: ");
            double t1 = Convert.ToDouble(Console.ReadLine());  //0
            Console.WriteLine("температура 2: ");
            double t2 = Convert.ToDouble(Console.ReadLine());  //10
            Console.WriteLine("диапазон изменения температуры: ");
            double t = Convert.ToDouble(Console.ReadLine());   //1
            Console.WriteLine("celsius | fahrenheit");
            do
            {
                f = t1 * 1.8 + 32;
                Console.WriteLine($"{t1} \t {f}");
                t1 = t + t1;
            }
            while (t1 <= t2);
            Console.ReadKey();
        }
    }
}
