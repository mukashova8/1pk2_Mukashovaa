using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_13_02
{
    internal class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public bool IsHealth { get; set; }

        public Pet()
        {
            
        }

        public Pet(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public Pet(string name, string type, int age)
        {
            Name =name; 
            Type = type; 
            Age = age;
        }

        public Pet(string name, string type, int age, int weight, bool isHealth)
        {
            Name=name;
            Type = type;
            Age = age;
            Weight = weight;
            IsHealth = isHealth;
        }

        public void GetInfo()
        {
            string n = IsHealth ? "Здоров" : "Нездоров";

            Console.WriteLine($"Кличка - {Name} \nВид - {Type} \nВозраст - {Age} \nВес - {Weight} кг \nОтметка о состоянии здоровья - {n}");
        }

        public void ChangeWeight(int weight)
        {
            Weight = weight;
            Console.WriteLine($"Измененный вес питомца {Name} - {Weight} кг");
        }

        public void ChangeHealht()
        {
            IsHealth = !IsHealth;
            if (IsHealth == true)
            {
                Console.WriteLine("Здоров");
            }
            else
            {
                Console.WriteLine("Нездоров");
            }
        }


    }
}
