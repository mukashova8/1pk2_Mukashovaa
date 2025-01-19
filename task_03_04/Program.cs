namespace task_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст илии exit для выхода");
            string t;
            int c = 0;
            while (true)
            {       
                t = Console.ReadLine();
                Console.Clear();
                if (t.ToLower() == "exit" || t == "")
                {
                    break;
                }
                c +=1;
            }
            Console.WriteLine($"Количество введенных строк: {c}"); 
            Console.ReadKey();  
        }
    }
}
