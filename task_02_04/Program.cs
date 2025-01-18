namespace task_02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит свою дату рождения построчно(сначала год, потом месяц и в конце дату)
            //произведите//расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение обэтом
            Console.WriteLine("Введите нынешний год :"); 
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите нынешний месяц :"); 
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите нынешний день :"); 
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год своего рождения :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц своего рождения :");
            int b = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Введите день своего рождения :");
            int c = Convert.ToInt32(Console.ReadLine());
            int f = y - a; 
            if ((z < b & f == 18) || (z == b & m < c))
            { 
                f -= 1; 
            }
            Console.WriteLine(f);
            if (f >= 18)
            {
                Console.WriteLine("Совершеннолетний");
            }
            else 
            { 
                Console.WriteLine("Несовершеннолетний"); 
            }
        }
    }
}
        