using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_32_01
{
    public class Kolobok
    {
        public int Position { get; private set; }
        public int Speed { get; set; }
        public bool IsAlive { get; set; }

        public Kolobok()
        {
            Position = 0;
            Speed = 4;
            IsAlive = true;
        }

        public void Roll()
        {
            Position += Speed;
            Console.WriteLine($"Колобок катится, текущая позиция: {Position}");
        }

        // Встреча с препятствием
        public void MeetObstacle(Obstacle obstacle)
        {
            if (!IsAlive)
            {
                return;
            }

            obstacle.InteractWith(this);
        }
    }
}
