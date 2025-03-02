using System.Linq.Expressions;

namespace task_06_06
{
    internal class Program
    {
        static void ArrayGeneration(int n)
        {
            int[,] mass = new int[n,n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = random.Next(-10, 10);
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //Создать Метод ArrayGeneration не возвращающий значения, принимает целое число n,
            //выводит наконсольсгенерированный массив размерности n*n.
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("ОШИБКА, ВВЕДИ СНОВА");
            }
            ArrayGeneration(n);
        }
    }
}
