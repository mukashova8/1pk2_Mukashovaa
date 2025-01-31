namespace task_05_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица Z-матрицей
            //(это матрица, где все недиагональные элементы меньше нуля)
            //Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали.Если не выполняется, то
            //вывести сообщение что данная матрица не является Z - матрицей


            int n;
            bool flag = true;
            Console.WriteLine("введите размерность массива: ");
            //ввод размерности массива с проверкой на корректность
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("ошибка, введите положительное целое число");
            }
            int[,] matrica = new int[n, n];
            Random rnd = new Random();
            Console.WriteLine("сгенерированная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrica[i, j] = rnd.Next(-10, 10);
                    Console.Write(matrica[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //проверка на Z-матрицу
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matrica[i, j] >= 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (!flag)
                    break;
            }
            if (flag)
            {
                Console.WriteLine("матрица Z: ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Write(matrica[i, j] + "\t");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(matrica[i, j] + "\t");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("данная матрица не является Z-матрицей");
            }
        }
    }    
}
