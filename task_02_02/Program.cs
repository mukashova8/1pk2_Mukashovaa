﻿namespace task_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Найти значение выражения при a = 8, b = 14, с = π / 4
            double a = 8;
            double b = 14;
            double c = Math.PI / 4;
            double f = (Math.Pow(b + Math.Pow(a - 1, 1 / 3), 1 / 4)) / (Math.Abs(a - b) * (Math.Sin(Math.Pow(c,2))) + Math.Tan(c));
            Console.WriteLine(f);
        }
    }
}
