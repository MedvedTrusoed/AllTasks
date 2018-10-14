using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ring r1 = new Ring();
            r1.Radius = 2;
            r1.InnerRadius = 1;

            Console.WriteLine($"Площадь кольца = {r1.SquadRing} Суммарная длина окружностей = {r1.SumLength}");
            Console.ReadKey();
        }
    }

    public class Round
    {
        private double radius;
        private float CenterX { get; set; }
        private float CenterY { get; set; }
        private float CenterZ { get; set; }

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                try
                {
                    if (value > 1000)
                    {
                        throw new Exception("Не многовато ли?");

                    }
                    else if (value <= 0)
                    {
                        throw new Exception("Таких радиусов не бывает");
                    }

                    else
                    {

                        radius = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                }
            }
        }

        public double Length
        {
            get
            {
                return radius * 2 * Math.PI;
            }
        }

        public double Squad
        {
            get
            {
                return Math.Pow(radius, 2) * Math.PI;
            }
        }

    }

    //описываемое координатами центра, внешним и внутренним радиусами, 
    //а также свойствами, позволяющими узнать площадь кольца 
    //и суммарную длину внешней и внутренней границ кольца.

    public class Ring : Round
    {
        private double innerRadius;

        public double InnerRadius
        {
            get
            {
                return innerRadius;
            }

            set
            {
                try
                {
                    if (value > Radius)
                    {
                        throw new Exception("Внутренний радиус должен быть поменьше :с");
                    }
                    else if (value <= 0)
                    {
                        throw new Exception("Таких радиусов не бывает");
                    }

                    else
                    {

                        innerRadius = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                }
                
            }
        }

        public double SquadRing
        {
            get
            {
                return Squad - Math.Pow(innerRadius, 2) * Math.PI;
            }
        }

        public double SumLength
        {
            get
            {
                return Length + innerRadius * 2 * Math.PI; ;
            }
        }

    }
}
