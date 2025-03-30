using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace task_20_06
{ 
    internal class Traffic
    {
        public TrafficLightColor Color { get; private set; } = TrafficLightColor.Red;
        private bool autoMode = true; 

        public void AutoSwitch()
        {
            Console.WriteLine("Автоматический режим: Нажмите Q для выхода");

            while (autoMode)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key; 
                    if (key == ConsoleKey.Q)
                    {
                        autoMode = false;
                        break;
                    }
                }

                Thread.Sleep(3000); 

              
                switch (Color)
                {
                    case TrafficLightColor.Red:
                        Color = TrafficLightColor.Green;
                        break;
                    case TrafficLightColor.Green:
                        Color = TrafficLightColor.Yellow;
                        break;
                    case TrafficLightColor.Yellow:
                        Color = TrafficLightColor.Red;
                        break;
                }

                Console.WriteLine($"Свет: {Color}");
            }
        }

        public void ManualSwitch()
        {
            Console.WriteLine("Ручной режим: Нажмите Enter для смены цвета, Q для выхода");

            while (!autoMode)
            {
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Q)
                {
                    break;
                }
                else if (key == ConsoleKey.Enter)
                {
                    Thread.Sleep(1000);

                    switch (Color)
                    {
                        case TrafficLightColor.Red:
                            Color = TrafficLightColor.Green;
                            break;
                        case TrafficLightColor.Green:
                            Color = TrafficLightColor.Yellow;
                            break;
                        case TrafficLightColor.Yellow:
                            Color = TrafficLightColor.Red;
                            break;
                    }

                    Console.WriteLine($"Свет: {Color}");
                }
            }
        }
    }
}


