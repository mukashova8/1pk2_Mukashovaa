using System.ComponentModel.Design;

namespace task_21_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать метод, который объединяет два словаря.
            //Если ключ присутствует в обоих словарях, суммировать их значения

            Dictionary<string, string> fruits = new Dictionary<string, string>()
            {
                { "1","яблоко" },
                { "2","груша"},
                { "3","банан"},
            };

            Dictionary<string, string> vegetables = new Dictionary<string, string>()
            {
                { "1", "огурец" },
                { "2","перец" },
                { "3","помидор" },
            };

            var resalt = Unification(fruits, vegetables);
            foreach (var item in resalt)
            {
                Console.WriteLine(item);
            }
        }
        static Dictionary<string, string> Unification(Dictionary<string, string> fruits, Dictionary<string, string> vegetables)
        {
            Dictionary<string, string> basket = new Dictionary<string, string>();
            foreach (var count in fruits)
            {
                basket[count.Key] = count.Value;
            }
            foreach (var count in vegetables)
            {
                if (basket.ContainsKey(count.Key))
                {
                    basket[count.Key] += "_"+ count.Value;
                }
                else
                {
                    basket[count.Key] = count.Value;
                }     
            }
            return basket;
        }
    }
}
