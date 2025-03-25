namespace task_19_02
{
    internal class Program
    {
        //2.Напишите программу, которая запрашивает у пользователя произвольный текст,
        //содержащий предложения (есть знаки препинания). программу после анализа выводит текст,
        //разделенный на части:
        //a)По пробелам(отдельные слова построчно)
        //b)По предложениям(отдельные предложения построчно)
        //(используйте метод Split())
        static void Main(string[] args)
        {
            Console.Write("Введи текст: ");
            string str = Console.ReadLine();
            char [] char1 = {'(', ')', '[', ']', '{', '}', ',', ' ', '.', '?', '!'};
            string [] wordsArrey = str.Split(char1);
            foreach (string word in wordsArrey)
            {
                Console.WriteLine(word);
            }
            char [] char2 = {'.', '!', '?'};
            string[] sentencesArrey = str.Split(char2);
            foreach (string sentences in sentencesArrey)
            {
                Console.WriteLine(sentences.Trim());
            }
        }
    }
}
