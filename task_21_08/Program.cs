using System.Net.Sockets;
using Microsoft.VisualBasic;

namespace task_21_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //напишите метод, который на вход получается массив параметров (строк)
            //и возвращает только уникальные строки

            List<string> list = new List<string>()
            {
                "Ананас",
                "Банан",
                "Дыня",
                "Ананас",
                "Банан",
                "Киви"
            };
            string[] uniqueStrings = TestString(list);
            Print(uniqueStrings);
        }
        static string[] TestString(List<string> list)
        {
            var list2 = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                if (!list2.Contains(list[i]))
                {
                    list2.Add(list[i]);
                }
            }
            return list2.ToArray();
        }

        public static void Print(string[] uniqueStrings)
        {
            for (int i = 0; i < uniqueStrings.Length; i++)
            {
                Console.WriteLine(uniqueStrings[i]);
            }
        }
    }
}
