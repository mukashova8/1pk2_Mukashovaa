namespace task_05_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Даны два массива размером 10*10, заполненные целыми числами в диапазоне от 1 до 9 вкл. Создать новый массив, который будет
            //произведением двух предыдущих(перемножить элементы первых двух массивов, стоящие на одинаковых позициях и записать их в
            //результирующий массив)
            //Вывести результирующий массив


            int[,] arrey1 = new int[10,10];
            int[,] arrey2 = new int[10,10];
            int[,] arrey3 = new int[10, 10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arrey1[i, j] = rnd.Next(1,10);
                    arrey2[i, j] = rnd.Next(1, 10);
                }
            }
            Console.WriteLine("первый массив: ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arrey1[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("второй массив: ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arrey2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //перемножаем элементы первых двух массивов, стоящие на одинаковых позициях
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arrey3[i, j] = arrey1[i, j] * arrey2[i,j];
                }
            }
            Console.WriteLine("результирующий массив: ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arrey3[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
