namespace task_04_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //В массиве хранятся сведения о количестве осадков за месяц(30 дней).Необходимо определить общее
            //количество осадков, выпавших за каждую декаду месяца, вывести день с самыми сильными осадками за месяц и
            //отдельно вывести дни без осадков.Массив с осадками заполнятся с помощью рандома в диапазоне от 0 – нет
            //осадков, до 300 мм выпавших осадков.

            //создание массива для хранения осадков за 30 дней
            int[] arrey = new int[30];
            Random rnd = new Random();
            //заполннение массивпа случайными данными от 0 до 300
            for (int i = 0; i < arrey.Length; i++)
            {
                arrey[i] = rnd.Next(0, 301);
            }
            //выводим данные о колитчестве осадеов 
            Console.WriteLine("количество осадков за месяц(в мм):");
            for (int i = 0; i < arrey.Length; i++)
            {
                Console.WriteLine($"День {i+1}: {arrey[i]} мм");
            }
            //определяем общее количество осадков за каджую декаду
            for (int decada = 0; decada < 3; decada++)
            {
                int y = decada * 10;
                int u = 0;
                for (int day = y; day < y + 10; day++)
                {
                    u += arrey[day];
                }
                Console.WriteLine($"Общее количество осадков {decada + 1}: {u}");
            }
            //находим день с самыми сильными осадками 
            int max1 = 0;
            int max2 = 0;
            for (int i = 0; i < arrey.Length; i++)
            {
                if (arrey[i] > max1)
                {
                    max1 = arrey[i];
                    max2 = i + 1;
                }
            }
            Console.WriteLine($"День с самыми сильными осадками: День {max2} ({max1} мм)");
            //дни без осадков
            Console.WriteLine("Дни без осадков: ");
            for (int i = 0; i < arrey.Length; i++)
            {
                if (arrey[i] == 0)
                {
                    Console.WriteLine($"День {i + 1}");
                }
            }
        }
    }
}
