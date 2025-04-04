using System;
using System.IO;
namespace task_24_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Реализуйте функцию, которая ищет заданное слово в текстовом файле и возвращает все строки,
            //содержащие это слово (регистро независимо).

            string fileName = "task.txt";
            string wordToFind = "Мир";
            File.Create(fileName).Dispose();
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Привет, мир!");
                writer.WriteLine("мир");
                writer.WriteLine("Привет");
            }

            List<string> searchLines = FindLines(fileName, wordToFind);
            if (searchLines.Count > 0)
            {
                Console.WriteLine("Найденные строки:");
                foreach (string line in searchLines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Строки не найдены.");
            }


        }
        static List<string> FindLines(string fileName, string word)
        {
            List<string> searchLines = new List<string>();
            string lowerCaseWord = word.ToLower();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null) 
                {
    
                    if (line.ToLower().IndexOf(lowerCaseWord) >= 0)
                    {
                        searchLines.Add(line);
                    }
                }
            }
            return searchLines; 
        }
    }
}
