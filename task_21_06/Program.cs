using System.Security.Cryptography.X509Certificates;

namespace task_21_06
{
    internal class Program
    {
        //Написать метод, который удаляет повторяющиеся элементы из списка, сохраняя порядок.
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 1, 2, 3, 4, 5
            };
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Чистка повторяющихся элементов: ");
            numbers = RemoveEl(numbers);
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
        static List<int> RemoveEl(List<int> numbers)
        {
            List<int> newnumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (!newnumbers.Contains(number))
                    newnumbers.Add(number);
            }
            return newnumbers;
        }
    }
}
