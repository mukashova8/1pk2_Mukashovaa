namespace task_24_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //реализуйте функцию, осуществляющую поиск текста в файле и его замену на значения,
            //введенные пользователем

            string fileName = "task.txt";
            File.Create(fileName).Dispose();
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Привет, мир!");
                writer.WriteLine("мир");
                writer.WriteLine("Привет");
            }

            Console.Write("Введите текст для поиска: ");
            string poisk = Console.ReadLine();


            Console.Write("Введите текст для замены: ");
            string zamena = Console.ReadLine();

            ChangeText(fileName, poisk, zamena);
            Console.WriteLine("Замена произошла: ");
            

        }
        static void ChangeText(string fileName, string poisk, string zamena)
        {
            string content;
            using (StreamReader reader = new StreamReader(fileName))
            {
                content = reader.ReadToEnd();
            }
            string newContent = content.Replace(poisk, zamena);
            Console.WriteLine(newContent);
        }
    }
}
