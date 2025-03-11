namespace task_11_02
{
    internal class Program
    {
        static void Change(ref int n, ref int m)
        {
            int t;
            t = n;
            n = m;
            m = t;
        }
        static void Main(string[] args)
        {
            //Передача по ссылке (ref): Напишите метод, который принимает два целых числа по ссылке и
            //меняет их местами.Проверьте, изменились ли значения переменных вне метода
            int n = 0, m = 0;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("ОШИБКА");
            }
            while (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("ОШИБКА");
            }
            Change(ref n, ref m);
            Console.WriteLine($"{n} {m}");
        }
    }
}
