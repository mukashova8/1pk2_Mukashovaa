﻿namespace task_11_06
{
    internal class Program
    {
        static void IncreaseElements(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] += 1;
            }
        }
        static void Print(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //Передача массива по значению: Напишите метод, который принимает массив целых чисел и
            //изменяет его элементы, увеличивая каждый на 1.Проверьте, изменился ли оригинальный
            //массив вне метода.
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("ОШИБКА, ВВЕДИ СНОВА");
            }
            int[] mass = new int[n];
            Random rnd = new Random();  
            Console.WriteLine("Оигинальный массив");
            for (int i = 0;i < mass.Length; i++)
            {
                mass[i] = rnd.Next(-10, 10);
                Console.WriteLine(mass[i] + " ");
            }
            Console.WriteLine("Увеличенный на 1");
            IncreaseElements(mass);
            Print(mass);
        }
    }
}
