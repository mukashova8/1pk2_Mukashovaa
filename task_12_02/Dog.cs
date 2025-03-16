using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_12_02
{
    internal class Dog
    {
        private int weight;
        public int tailLenght;
        public int bodyLenght;
        public string name;
        private int age;

        public void Weight()
        {
            weight = 50;
            Console.WriteLine($"Вес собаки {weight} кг");
        }
        public void Age()
        {
            age = 5;
            Console.WriteLine($"Возраст собаки {age} лет");

        }
    }
}
