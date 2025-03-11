namespace task_11_01
{
    internal class Program
    {
        static void Mesta(int n, int m)
        {
            int t;
            t = n;
            n = m;
            m = t; 
        }
        static void Main(string[] args)
        {
            //Передача по значению: Напишите метод, который принимает два целых числа и меняет их
            //местами. Проверьте, изменились ли значения переменных вне метода
            int n = 0, m = 0;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("ОШИБКА");
            }
            while (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("ОШИБКА");
            }
            Mesta(n, m);
            Console.WriteLine($"{n} {m}");
        }
    }
}
