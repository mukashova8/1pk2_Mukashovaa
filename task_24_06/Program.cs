using System;
using System.IO;
namespace task_24_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите метод, который принимает путь к файлу и возвращает количество строк в нем.
            //Используйте StreamReader.


            string fileName = @"C:\Users\Алина\source\1pk2_Mukashov\a\task_24_06\bin\Debug\net8.0\task.txt";
            string content = "Первая строка\nВторая строка\nТретья строка";
            File.Create(fileName).Dispose();

            File.WriteAllText(fileName,content);

            int lineCount = CountLinesInFile(fileName);
            Console.WriteLine($"Количество строк в файле: {lineCount}");

        }
        static int CountLinesInFile(string fileName)
        {
            int lineCount = 0;
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++; 
                }
            }
            return lineCount; 
        }
    }
}
