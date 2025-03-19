using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task_14_03
{
    public static class Matesha
    {
        public static int Factorial(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Число должно быть положительным.");
                return 0;
            }
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i; 
            }
            return f;
        }
    }
}
