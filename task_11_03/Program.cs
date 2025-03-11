namespace task_11_03
{
    internal class Program
    {
        static void Podschet(string input, out int countGl, out int countSogl)
        {
            countGl = 0;
            countSogl = 0;
            char[] massGl = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
            char[] massSogl = { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };
            // Приводим строку к нижнему регистру для удобства сравнения
            input = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < massGl.Length; j++)
                {
                    if (input[i] == massGl[j])
                    {
                        countGl++;
                    }
                }
                for (int j = 0; j < massSogl.Length; j++)
                {
                    if (input[i] == massSogl[j])
                    {
                        countSogl++;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Выходной параметр (out): Напишите метод, который принимает строку и возвращает через
            //выходной параметр количество гласных и согласных букв в этой строке
            string inputs = Console.ReadLine();
            int countGl, countSogl;
            Podschet(inputs, out countGl, out countSogl);
            Console.WriteLine($"Количество гласных {countGl}");
            Console.WriteLine($"Количество согласных {countSogl}");
        }
    }
}
