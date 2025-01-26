using System.Numerics;
using System;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task_04_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Заполнить массив случайными положительными и отрицательными числами таким образом, чтобы все числа по
            //модулю были разными.Это значит, что в массиве не может быть ни только двух равных чисел, но не может быть
            //двух равных по модулю.В полученном массиве найти наибольшее по модулю число

            //создвем массим с размером 10
            int size = 10;
            int [] arrey = new int [size];
            Random rdn = new Random();
            //заполняю массив уникальными числами 
            for (int i = 0; i < size; i++)
            {
                int d = rdn.Next(-10, 10);
                bool flag;
            //проверка чисел
                do
                {
                    d = rdn.Next(-10, 10);
                    flag = true;
                    for (int j = 0; j < i; j++)
                    {   
                
                        if (Math.Abs(d) == Math.Abs(arrey[j]))
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                while (flag == false || d == 0);
            arrey[i] = d;
            Console.WriteLine(arrey[i]);
            }
            //максимальное значение
            int max = 0;
            for (int i = 0; i < size; i++)
            {
                if ((arrey[i] > max))
                { 
                    max = arrey[i];
                }
            }
            Console.WriteLine($"максимальное значенсие: {max}");
        }
    }
}
