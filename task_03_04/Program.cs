namespace task_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводить в консоли произвольный текст. После каждого ввода консоль очищается. Когда
            //пользователь вводить слово «exit» или пустую строку – ввод останавливается и выводиться количество строк
            //введенных пользователем.

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
