using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    //Написать класс, описывающий треугольник со сторонами a, b, c,
    //и методами, позволяющими осуществить расчёт его площади и периметра.

    class Triangle
    {
        private float a;
        private float b;
        private float c;

        public float A
        {
            set
            {
                if (a <= 0)
                {
                    Console.WriteLine("У треугольника нет отрицательных сторон");
                }
                else if (b + c < a)
                {
                    Console.WriteLine("сумма 2х сторон треугольника должна быть больше третьей");
                }
                else 
                {
                   a = value;
                }
            }
            get
            {
                return a;
            }
        }
        public float B
        {
            set
            {
                if (b <= 0)
                {
                    Console.WriteLine("У треугольника нет отрицательных сторон");
                }
                else if (a + c < b)
                {
                    Console.WriteLine("сумма 2х сторон треугольника должна быть больше третьей");
                }
                else
                {
                    b = value;
                }
            }
            get
            {
                return b;
            }
        }
        public float C
        {
            set
            {
                if (c <= 0)
                {
                    Console.WriteLine("У треугольника нет отрицательных сторон");
                }
                else if (b + a < c)
                {
                    Console.WriteLine("сумма 2х сторон треугольника должна быть больше третьей");
                }
                else
                {
                    c = value;
                }
            }
            get
            {
                return c;
            }
        }

        public double Square
        {
            get
            {
                double p = 0.5 * (a + b + c);
                return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            }
        }
        public double Perimeter
        {
            get
            {
                return a+b+c;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
