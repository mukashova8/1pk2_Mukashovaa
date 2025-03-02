using System;
using System.Linq.Expressions;

namespace task_06_07
{
    internal class Program
    {
        static char[,] GenerateAlphabet(int n)
        {
            char[,] mass = new char[n, n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = (char)random.Next(1040, 1103);
                }
            }
            return mass;
        }
        static void Print(char[,] mass)
        {
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //Создайте метод с помощью которого можно сгенерировать и вернуть символьный двумерныймассив
            //(состоящий из символов русского алфавита) и выведите на консоль данный массив с помощью другого
            //метода(который принимает данный массив в качестве параметра)
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("ОШИБКА, ВВЕДИ СНОВА");
            }
            char[,] mass = new char[n, n];
            mass = GenerateAlphabet(n);
            Print(mass);

        }
    }
}
