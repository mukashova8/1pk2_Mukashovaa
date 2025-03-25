using static System.Net.Mime.MediaTypeNames;

namespace task_19_03
{
    internal class Program
    {
        //3.Напишите консольное приложение, в котором осуществляется построчный пользовательский ввод
        //(ввод каждой строки подтверждается нажатием на enter). количество введенных строк произвольно,
        //ввод завершается при вводе пустой строки. 
        //После окончания ввода произведите объединение всех ранеее введенных строк в одну с использованием
        //разделителя «-»
        //Например:
        //Введите строку 1: "Hello"
        //Введите строку 2: "world"
        //Введите строку 3: "C#"
        //Результат: "Hello-world-C#"
        static void Main(string[] args)
        {
            string str;
            string result = "";
            while (true)
            {
                str = Console.ReadLine();
                if (str == "")
                { 
                    break;
                }
                if (!string.IsNullOrEmpty(result))
                {
                    result += "-";
                }
                result += str;
            }
            Console.WriteLine($"Результат: {result} ");


        }
    }
}
