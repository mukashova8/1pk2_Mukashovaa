﻿namespace task_05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Даны два массива, заполненные символами английского алфавита размером 3*3. Проверить, являются ли матрицы равными, если
            //да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех
            //элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны. 

            char[,] alfavit = new char[3, 3];
            char[,] alfavit2 = new char[3, 3];
            Random rnd = new Random();
            bool pocaz = true;
            for (int i = 0; i < alfavit.GetLength(0); i++)
                for (int j = 0; j < alfavit.GetLength(1); j++)
                {
                    alfavit[i, j] = (char)('a' + rnd.Next(0, 10));
                    alfavit2[i, j] = (char)('a' + (rnd.Next(0, 10)));
                }

            for (int i = 0; i < alfavit.GetLength(0); i++)
            {
                for (int j = 0; j < alfavit.GetLength(1); j++)
                {
                    Console.Write(alfavit[i, j] + " ");
                }
                Console.Write("   ");
                for (int j = 0; j < alfavit2.GetLength(1); j++)
                {
                    Console.Write(alfavit2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------");
            for (int i = 0; i < alfavit.GetLength(0); i++)
            {
                for (int j = 0; j < alfavit.GetLength(1); j++)
                {
                    if (alfavit[i, j] != alfavit2[i, j])
                    {
                        pocaz = false;
                    }
                }
            }
            if (pocaz == true)
            {
                Console.WriteLine("Матрицы равны");
            }
            else
            {
                for (int i = 0; i < alfavit.GetLength(0); i++)
                {
                    for (int j = 0; j < alfavit.GetLength(1); j++)
                    {
                        if (alfavit[i, j] == alfavit2[i, j])
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        Console.Write(alfavit[i, j]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }
                    Console.Write("   ");
                    for (int j = 0; j < alfavit2.GetLength(1); j++)
                    {
                        if (alfavit[i, j] == alfavit2[i, j])
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        Console.Write(alfavit2[i, j]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
