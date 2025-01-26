namespace task_04_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //В массиве найти элементы, которые в нем встречаются только один раз, и вывести их на экран. То есть найти и
            //вывести уникальные элементы массива. (LINQ использовать нельзя)

            //создаем массив
            int size = 10;
            int[] arrey = new int[size];
            Random rdn = new Random();
            for (int i = 0; i < size; i++)
            {
                arrey[i] = rdn.Next(0, 20);
                Console.WriteLine(arrey[i]);
            }
            //ищем уникальные элементы
            Console.WriteLine($"уникальные числа: ");
            bool flag = true;
            for (int i = 0; i < size; i++)
            {
                flag = true;
                for (int j = 0; j < size; j++)
                {
                    if (arrey[i] == arrey[j] && i !=j)
                    {
                        flag = false; 
                    }        
                }
                
                if (flag == true)
                {
                    Console.WriteLine(arrey[i]);
                }
            }
            
        }
    }
}
