using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Round : Figure
    {
        private double radius;
        private float centerX;
        private float centerY;

        public Round(float x, float y, double radius)
        {
            if (radius > 1000)
            {
                throw new Exception("Не многовато ли?");
            }
            else if (radius <= 0)
            {
                throw new Exception("Таких радиусов не бывает");
            }

            else
            {
                this.radius = radius;
                centerX = x;
                centerY = y;
            }
        }

        public double Length
        {
            get
            {
                return Math.Round(radius * 2 * Math.PI);
            }
        }

        public double Squad
        {
            get
            {
                return Math.Round(Math.Pow(radius, 2) * Math.PI);
            }
        }
        public override void Draw()
        {
            Console.WriteLine($"Длина окружности = {Length} Площадь = {Squad}");
        }

    }
}
