using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace task_13_03
{
    internal class Car
    {
        public int Number { get; set; }
        public string Mark { get; set; }
        public string Color { get; set; }
        public double Speed { get; set; }

        public Car()
        {
            
        }

        public Car(int number, string color)
        {
            Number = number;
            Color = color;
        }

        public Car(int number, string mark, string color)
        {
            Number =number;
            Mark =mark;
            Color =color;
        }

        public Car(int number, string mark, string color, int speed)
        {
            Number = number;
            Mark = mark;
            Color = color;
            Speed = speed;
        }

        public void SpeedBoost(double max)
        {
            while (Speed < max)
            {
                Speed = Speed + 0.5;
                Console.WriteLine($"Ускорение: Текущая скорость автомобиля: {Speed} км/ч");
            }
            StopCar();
        }

        private void StopCar()
        {
            Console.WriteLine("Торможение: Автомобиль остановлен из-за превышения скорости");
            while (Speed != 0)
            {
                Speed = Speed - 0.5;
                Console.WriteLine($"Снижение скорости: Текущая скорость автомобиля: {Speed} км/ч");
            }
            Console.WriteLine("Автомобиль остановлен");
        }

    }
}
