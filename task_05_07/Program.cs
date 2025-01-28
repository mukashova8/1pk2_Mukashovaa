namespace task_05_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //У пользователя в консоли запрашивается число n, генерируется квадратный массив целых числе [n*n]. Заполнение случайными
            //числами в диапазоне от 10 до 99 включительно.
            //Найти и вывести отдельно минимальный элемент в матрице(LINQ под запретом) Осуществить умножение матрицы на ее
            //минимальный элемент, при выводе цветом выделить пять максимальных значений в массиве

            int n, min = 100, max = 0;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("ошибка, введите снова");
            }
            int[,] arrey = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arrey[i, j] = rnd.Next(10, 100);
                    if (arrey[i, j] < min)
                    {
                        min = arrey[i, j];
                    }
                    if (arrey[i, j] > max)
                    {
                        max = arrey[i, j];
                    }
                    Console.Write(arrey[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine(min);

        }    
    }
}
