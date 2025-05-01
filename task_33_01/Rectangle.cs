using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_33_01
{
    internal class Rectangle : IDrawable
    {
        //самостоятельно прописатьтреугольник и его логику рисования в консоли
        //для упрощения  - прямугольный треугольник

        private int lenght;
        public int Lenght
        {
            get => lenght;
            set
            {
                if (value < 1)
                    throw new ArgumentException("длина должна быть больше 1");
                else lenght = value;

            }
        }

        public Rectangle(int lenght)
        {
            Lenght = lenght;
        }

        public void Draw()
        {
            Console.WriteLine();
            for (int i = 0; i <= lenght; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
