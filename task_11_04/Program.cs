namespace task_11_04
{
    internal class Program
    {
        static double SredneeZnachenie(params double[] numberArray)
        {
            double sum = 0;
            foreach (double number in numberArray)
            {
                sum += number;
            }
            double n = sum / numberArray.Length;
            return n;
        }
        static void Main(string[] args)
        {
            //Массив параметров (params): Напишите метод, который принимает массив чисел и возвращает
            //их среднее значение.Используйте ключевое слово params
            double[] numberArray = new double[10];
            Random random = new Random();
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = random.Next(-10, 10);
                Console.WriteLine(numberArray[i] + " ");
            }
            Console.WriteLine();
            double n = SredneeZnachenie(numberArray);
            Console.WriteLine($"Среднее значение {n}");
        }
    }
}
