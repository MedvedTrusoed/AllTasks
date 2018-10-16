using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        private float a;
        private float b;
        private float c;

        public Triangle(float a, float b, float c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("У треугольника не может быть отрицательных сторон");
            }
            else if ((b + c <= a) || (a + b <= c) || (a + c <= b))
            {
                throw new Exception("сумма 2х сторон треугольника должна быть больше третьей");
            }
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public double Square
        {
            get
            {
                double p = 0.5 * (a + b + c);
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
        public double Perimeter
        {
            get
            {
                return a + b + c;
            }
        }
    }
}
