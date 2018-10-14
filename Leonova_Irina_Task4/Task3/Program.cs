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
                try
                {
                    if (value <= 0)
                    {
                        throw new Exception("У треугольника нет отрицательных сторон");
                    }
                    else if (b + c < value)
                    {
                        throw new Exception("сумма 2х сторон треугольника должна быть больше третьей");
                    }
                    else
                    {
                        a = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
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
                try
                {
                    if (value <= 0)
                    {
                        throw new Exception("У треугольника нет отрицательных сторон");
                    }
                    else if (a + c < value)
                    {
                        throw new Exception("сумма 2х сторон треугольника должна быть больше третьей");
                    }
                    else
                    {
                        b = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
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
                try
                {
                    if (value <= 0)
                    {
                        throw new Exception("У треугольника нет отрицательных сторон");
                    }
                    else if (b + a < value)
                    {
                        throw new Exception("сумма 2х сторон треугольника должна быть больше третьей");
                    }
                    else
                    {
                        c = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
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
