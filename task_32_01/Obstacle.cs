using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_32_01
{
    public abstract class Obstacle
    {
        public string Name { get; }

        protected Obstacle(string name)
        {
            Name = name;
        }

        // Метод, который определяет действие препятствия при встрече с колобком
        public abstract void InteractWith(Kolobok kolobok); //cталкнуться с...
    }
}
