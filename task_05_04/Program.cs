namespace task_05_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица
            //диагональной(все элементы вне главной диагонали равны нулю)
            //Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси
            //сообщение что матрица не является диагональной.

            //создание квадратного массива и проверка ввода
            int n; bool b = true;
            Random rnd = new Random();
            Console.WriteLine("введите длину массива");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("ошибка ввода");
            }
            int[,] arrey = new int[n, n];
            for (int i = 0; i < arrey.GetLength(0); i++)
            {
                for (int j = 0; j < arrey.GetLength(1); j++)
                {
                    arrey[i, j] = rnd.Next(0, 2); //если 2 заменить на 1 работает все 
                }
            }
            //задача 
            for (int i = 0; i < arrey.GetLength(0); i++)
            {
                for (int j = 0; j < arrey.GetLength(1); j++)
                {
                    if (i != j & arrey[i, j] != 0)
                        b = false;
                }
            }
            if (b == true)
            {

                for (int i = 0; i < arrey.GetLength(0); i++)
                {
                    for (int j = 0; j < arrey.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(arrey[i, j]);
                        }
                        else
                        { Console.Write(arrey[i, j]); }
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }

                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("матрица не диагональная");
        }
        
    }
}

