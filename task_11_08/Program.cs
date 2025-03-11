namespace task_11_08
{
    internal class Program
    {
        static void SumAndMax(out double summ, out double max, params double[] mass)
        {
            summ = 0;
            max = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                summ += mass[i];
                if (max < mass[i])
                {
                    max = mass[i];
                }
            }
        }
        static void Main(string[] args)
        {
            //Использование params и out: Напишите метод, который принимает переменное количество
            //чисел и возвращает их сумму и максимальное значение через выходные параметры(out)

            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n))
            //{
            //    Console.WriteLine("ОШИБКА, ВВЕДИ СНОВА");
            //}
            double summ, max;
            //double [] mass = new double[n];
            //Random rnd = new Random();
            //for (int i = 0;i < n;i++)
            //{
            //    mass[i] = rnd.Next(-10, 10);
            //    Console.WriteLine(mass[i] + " ");
            //}
            Console.WriteLine();
            SumAndMax(out summ, out max, 1, 2, 3, 4, 5 ,6, 7, 8, 9);
            Console.WriteLine($"Сумма: {summ}");
            Console.WriteLine($"Максимальное значение: {max}");
        }
    }
}
