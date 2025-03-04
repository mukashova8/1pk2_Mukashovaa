namespace task_06_08
{
    internal class Program
    {
        static int PoickElimenta(int n, int[] mass)
        {
            for (int i = 0; i < n; i++)
            {
                if (mass[i] == n)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            //Создайте метод, который на вход принимает одномерный массив и число для поиска,
            //верните индексискомогоэлемента в массиве. Если элемента нет – верните индекс = -1
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("ОШИБКА");
            }
            int[] mass = new int[10];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                mass[i] = random.Next(-10, 10);
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine();
            int g = PoickElimenta(n, mass);
            Console.WriteLine(g);
        }
    }
}
