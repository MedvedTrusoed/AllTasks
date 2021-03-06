﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //Написать класс Round, задающий круг с указанными координатами центра,
    //радиусом, а также свойствами, позволяющими узнать длину описанной окружности и площадь круга.
    class Round
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

                if (radius > 1000)
                {
                    Console.WriteLine("Не многовато ли?");
                }
                else if (radius <= 0)
                {
                    Console.WriteLine("Таких радиусов не бывает");
                }

                else
                {

                    radius = value;
                }
            }
        }

        public double Length
        {
            get
            {
                return radius*2*Math.PI;
            }
        }

        public double Squad
        {
            get
            {
                return Math.Pow(radius,2) * Math.PI;
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
