using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_32_01
{
    public abstract class Animal : Obstacle
    {
        public string Name { get; } //название животного

        //конструктор, который будет срабатывать в дочерних классах
        //т.к. используется protected
        public Animal(string name) : base(name)
        {
            Name = name;
        }
        //все животные захотят съесть колобка
        //но вот получится ли - вопрос...
        public abstract bool CanEat(Kolobok kolobok);
        public override void InteractWith(Kolobok kolobok)
        {
            if (CanEat(kolobok))
            {
                kolobok.IsAlive = false;
                Console.WriteLine($"{Name} съел колобка!");
            }
            else
            {
                Console.WriteLine($"Колобок убежал от {Name}!");
            }
        }
    }
}
