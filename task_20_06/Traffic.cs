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
        bool time = true;

        public void AftoSwitch()
        {

            Console.WriteLine("Нажмите Q для выхода");
            while (time)
            {

                Thread.Sleep(3000);

                switch (Color)
                {
                    case TrafficLightColor.Red:
                        Color = TrafficLightColor.Green; break;
                    case TrafficLightColor.Green:
                        Color = TrafficLightColor.Yellow; break;
                    case TrafficLightColor.Yellow:
                        Color = TrafficLightColor.Red; break;
                }
                Console.WriteLine($"Свет: {Color}");
                var key = Console.ReadLine();
                if (key == "Q")
                {
                    time = false;
                }


            }
        }
        public void Switch()
        {
            Console.WriteLine("Нажмите enter для смены цвета");
            var key = Console.ReadLine();
            while (time)
            {
                if (key == "")
                {
                    Thread.Sleep(3000);
                    switch (Color)
                    {
                        case TrafficLightColor.Red:
                            Color = TrafficLightColor.Green; break;
                        case TrafficLightColor.Green:
                            Color = TrafficLightColor.Yellow; break;
                        case TrafficLightColor.Yellow:
                            Color = TrafficLightColor.Red; break;
                    }

                    Console.WriteLine($"Свет: {Color}");

                }

            }
        }
    }
}

