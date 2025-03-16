using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_12_02
{
    internal class Cat
    {
        private int weight;
        public int tailLenght;
        public int bodyLenght;
        public string name;
        private int age;

        public void Weight()
        {
            weight = 6;
            Console.WriteLine($"Вес кошки {weight} кг");
        }
        public void Age()
        {
            age = 16;
            Console.WriteLine($"Возраст кошки {age} лет");
        }
    }
}
