using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_32_01
{
    public class Wall : Obstacle
    {
        public Wall() : base("Стена")
        {
        }

        public override void InteractWith(Kolobok kolobok)
        {
            Console.WriteLine($"Колобок ударился о {Name} и потерял скорость.");
            kolobok.Speed /= 2; // Затормаживание
        }
    }
}
