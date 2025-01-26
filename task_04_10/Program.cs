namespace task_04_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Заполнить массив из 10 элементов случайными числами в интервале [-10..10] и сделать реверс элементов
            //отдельно для 1 - ой и 2 - ой половин массива. Реверс реализовать через цикл. Стандартные методы класса Array
            //использовать нельзя.

            //создаем массив
            int size = 10;
            int[] arrey = new int[size];
            Random rdn = new Random();
            
            for (int i = 0; i < size; i++)
            {
                arrey[i] = rdn.Next(-10, 10);
                Console.Write( arrey[i] + " ");
            }

            //реверс первой половины массива 
            int l = 0;
            int r = arrey.Length / 2 - 1;
            while (l < r)
            {
                int temp = arrey[l];
                arrey[l] = arrey[r];
                arrey[r] = temp;
                l++;
                r--;
            }
            //реверс второй половины массива
            l = arrey.Length / 2;
            r = arrey.Length - 1;
            while (l < r)
            {
                int temp = arrey[l];
                arrey[l] = arrey[r];
                arrey[r] = temp;
                l++;
                r--;
            }
            Console.WriteLine();
            foreach (var item in arrey)
            {
                
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}