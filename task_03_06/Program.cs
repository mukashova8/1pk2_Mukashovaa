namespace task_03_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥|для -4≤x≤4, с шагом h = 0,5.
            Console.WriteLine("таблица значений");
            for (double x = -4; x <= 4; x = x + 0.5)
            {
                double y = Math.Abs(x);
                Console.WriteLine($"{x} \t {y}");
            }




        }
    }
}
