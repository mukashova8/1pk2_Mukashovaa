namespace task_05_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Осуществить генерация двумерного [10*5] массива по следующему правилу:
            //• 1 столбец содержит нули
            //• 2 столбце содержит числа кратные 2
            //• 3 столбец содержит числа кратные 3
            //• 4 столбец содержит числа кратные 4
            //• 5 столбец содержит числа кратные 5
            //Осуществить переворот массива(поменять строки и столбцы местами) вывести обновленный массив

            //создание массива 
            int[,] arrey = new int[10, 5];
            Random random = new Random();
            //проверка на каждый пункт условия
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 0)
                        arrey[i, j] = 0;
                    else if (j == 1)
                    {
                        arrey[i, j] = random.Next(1,21);
                        if (arrey[i, j] % 2 != 0)
                        {
                            arrey[i, j] += 1;
                        }
                    }
                    else if (j == 2)
                    {
                        arrey[i, j] = random.Next(1,21);
                        if (arrey[i, j] % 3 == 2)
                        {
                            arrey[i, j] += 1;
                        }
                        else if (arrey[i, j] % 3 == 1)
                            arrey[i, j] += 2;
                        
                    }
                    else if (j == 3)
                    {
                        arrey[i, j] = random.Next(1, 21);
                        
                            if (arrey[i, j] % 4 == 3)
                                arrey[i, j] += 1;
                            else if (arrey[i, j] % 4 == 2)
                                arrey[i, j] += 2;
                            else if (arrey[i, j] % 4 == 1)
                                arrey[i, j] += 3;
                        
                    }
                    else if (j == 4)
                    {
                        arrey[i, j] = random.Next(1, 21);
                        
                            if (arrey[i, j] % 5 == 4)
                                arrey[i, j] += 1;
                            else if (arrey[i, j] % 5 == 3)
                                arrey[i, j] += 2;
                            else if (arrey[i, j] % 5 == 2)
                                arrey[i, j] += 3;
                            else if(arrey[i, j] % 5 == 1)
                                arrey[i, j] += 4;
                        
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arrey[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------");
            //переворот
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arrey[j,i] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
