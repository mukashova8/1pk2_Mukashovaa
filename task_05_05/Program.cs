namespace task_05_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе [n*m]. Заполнение
            //случайными числами в диапазоне от - 99 до 99 включительно.Осуществите без создания нового массива преобразование текущего
            //по следующему правилу:
            //• Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
            //• Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом 

            //проверяем то , что пользователь вводит число
            int n, m;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("ошибка, введите снова");
            }
            while (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("ошибка, введите снова");
            }
            //создаем прямоугольный двумерный массив 
            int[,] pr = new int[n, m];
            Random rnd = new Random();
            //проверяем массив 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    pr[i, j] = rnd.Next(-99, 100);
                    if (pr[i, j] < 0)
                    {
                        pr[i, j] = Math.Abs(pr[i, j]);
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(pr[i, j] + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (pr[i, j] == 0)
                    {
                        pr[i, j] = 1;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(pr[i, j] + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.Write(pr[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
