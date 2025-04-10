﻿namespace task_19_01
{
    internal class Program
    {
        //1. Напишите программу, в которой пользователь вводит произвольный текст в консоли,
        //после чего программа запрашивает подстроку для поиска. Если подстрока найдена - то программа
        //запрашивает текст для того чтобы заменить на него эту подстроку (столько раз, сколько раз подстрока
        //встречена в тексте)
        //Пример:
        //Введите строку: "Привет, мир!"
        //Введите подстроку для поиска: "мир"
        //Введите подстроку для замены: "друг"
        //Результат: "Привет, друг!"
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            Console.Write("Введите подстроку для поиска: ");
            string substr = Console.ReadLine();
            if (str.Contains(substr))
            {
                Console.Write("Введите подстроку для замены: ");
                string substr2 = Console.ReadLine();
                str = str.Replace(substr, substr2);
            }
            else
            {
                str = "подстрока не найдена";
            }
            Console.Write($"Результат: {str}");
        }
    }
}
