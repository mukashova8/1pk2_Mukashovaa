namespace task_11_05
{
    internal class Program
    {
        static void Kombinirovanie(ref double x, ref double y, out double sum, out double proizved)
        {
            sum = x + y;
            proizved = x * y;
        }
        static void Main(string[] args)
        {
            //Комбинирование ref и out: Напишите метод, который принимает два числа по ссылке(ref) и
            //возвращает их сумму и произведение через выходные параметры(out).
            double x = 0, y = 0;
            double sum, proizved;
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("ОШИБКА");
            }
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("ОШИБКА");
            }
            Kombinirovanie(ref x, ref y, out sum, out proizved);
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {proizved}");
        }
    }
}
