using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_20_06
{
    internal class Traffic
    {
        public TrafficLightColor Color { get; private set; } = TrafficLightColor.Red;
        bool autoMode = true;

        public void AutoSwitch()
        {
            Console.WriteLine("Автоматический режим: Нажмите Q для выхода");
            while (autoMode)
            {
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

                var key = Console.ReadKey(true).KeyChar.ToString();
                if (key == "Q")
                {
                    autoMode = false;
                }
            }
        }

        public void ManualSwitch()
        {
            Console.WriteLine("Ручной режим: Нажмите Enter для смены цвета, Q для выхода");

            while (!autoMode)
            {
                var key = Console.ReadKey(true).KeyChar.ToString();

                if (key == "Q")
                {
                    break;
                }
                else if (key == "\r")
                {
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
        }

    }
}
