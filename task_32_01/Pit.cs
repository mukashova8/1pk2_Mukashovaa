﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_32_01
{
    public class Pit : Obstacle
    {
        public Pit() : base("Яма")
        {
        }

        public override void InteractWith(Kolobok kolobok)
        {
            Console.WriteLine($"Колобок провалился в {Name} и потерял скорость.");
            kolobok.Speed /= 2; // Затормаживание
        }
    }
}
