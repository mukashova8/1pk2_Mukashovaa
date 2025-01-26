using System.Security.Cryptography;

namespace task_04_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //В массиве на 30 элементов содержатся данные по росту учеников в классе. Рост мальчиков условно задан
            //отрицательными значениями. Вычислить и вывести количество мальчиков и девочек в классе и средний рост для
            //мальчиков и девочек. При выводе избавиться от отрицательных значений.

            //создание массива
            int size = 30;
            int[] arrey = new int[size];
            Random rdn = new Random();
            int c1 = 0;
            int c2 = 0;
            double s1 = 0, s2 = 0;
            for (int i = 0; i < size; i++)
            {
            //генерируем рандомное значение мальчки или девочка 
                int d = rdn.Next(0, 2);
            //генерируем ранндомное значение для мальчика
                if (d == 0)
                {
                    arrey[i] = rdn.Next(-200, -100);
                    c1 += 1;
                    s1 += arrey[i];
                }
            //генерируем ранндомное значение для мальчика
                else if (d == 1)
                {
                    arrey[i] = rdn.Next(100, 200);
                    c2 += 1;
                    s2 += arrey[i];
                }
                Console.WriteLine(Math.Abs(arrey[i]));
            }
            Console.WriteLine($"количество мальчиков: {c1}");
            Console.WriteLine($"количество девочек: {c2}");
            Console.WriteLine($"средний рост мальчиков: {Math.Abs(s1/c1)}");
            Console.WriteLine($"средний рост девочек: {s2 / c2}");
        }
    }
}
