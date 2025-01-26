using System.Diagnostics.Metrics;

namespace task_04_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дан массив, содержащий последовательность 50 случайных чисел. Найти количество пар элементов, значения
            //которых равны.

            //создаем массив
            int size = 50;
            int[] arrey = new int[size];
            Random rdn = new Random();
            int c = 0;
            for (int i = 0; i < size; i++)
            {
                arrey[i]  = rdn.Next(0, 50);
                Console.WriteLine(arrey[i]);
            }
            //ищем пары чисел
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arrey[i] == arrey[j])
                    {
                        c++;
                        Console.WriteLine($"пара: {arrey[i]}");
                    }

                }
            }
            Console.WriteLine($"количесвто пар чисел: {c}");
        }
    }
}
