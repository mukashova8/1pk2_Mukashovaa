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

            int n, min = 100;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка, введите снова");
            }

            int[,] array = new int[n, n];
            Random rnd = new Random();

            //Генерация матрицы и нахождение минимального элемента
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(10, 100);
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Минимальный элемент: {min}");

            //Умножение матрицы на минимальный элемент
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] *= min;
                }
            }

            //Нахождение пяти максимальных элементов вручную
            int[] maxValues = new int[5];
            for (int k = 0; k < 5; k++)
            {
                int max = int.MinValue;

            //Поиск максимального элемента, который еще не был найден
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        bool isAlreadyIncluded = false;

            //Проверяем, есть ли элемент в массиве maxValues
                        for (int m = 0; m < k; m++)
                        {
                            if (array[i, j] == maxValues[m])
                            {
                                isAlreadyIncluded = true;
                                break;
                            }
                        }

                        if (!isAlreadyIncluded && array[i, j] > max)
                        {
                            max = array[i, j];
                        }
                    }
                }

                maxValues[k] = max; //Сохраняем найденный максимум
            }

            Console.WriteLine("Матрица после умножения:");
            //Вывод матрицы с выделением пяти максимальных элементов
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    bool isHighlighted = false;

            //Проверяем, нужно ли выделить текущий элемент
                    for (int k = 0; k < 5; k++)
                    {
                        if (array[i, j] == maxValues[k])
                        {
                            isHighlighted = true;
                            break;
                        }
                    }

                    if (isHighlighted)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; //Цвет для максимальных значений
                    }
                    Console.Write(array[i, j] + "\t");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }   
    }
}
