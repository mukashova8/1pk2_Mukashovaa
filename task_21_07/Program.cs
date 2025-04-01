using System.Collections.Generic;

namespace task_21_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать метод, который находит первый ключ в словаре, соответствующий заданному значению.
            //Если значения нет, вернуть null.

            Dictionary<string, string> slovar = new Dictionary<string, string>()
            {
                { "Материал 1" , "Краска"},
                { "Материал 2" , "Хна"},
                { "Материал 3", "Состав для ламинирования"},
            };
            
            Console.Write("Введите значение - ");
            string value = Console.ReadLine();
            string a = Test(slovar, value);
            Console.WriteLine($"Ключ - {a}");
        }
        static string Test(Dictionary<string, string> slovar, string value)
        {
            foreach (var kvp in slovar)
            {
                if (slovar.ContainsValue(value))
                {
                    return kvp.Key;
                }
            }
            return null;
        }
    }
}
