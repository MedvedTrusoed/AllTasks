using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Ring : Round
    {
        private double innerRadius;

        public Ring(float x, float y, float z) : base(x, y, z)
        {
        }

        public double InnerRadius
        {
            get
            {
                return innerRadius;
            }

            set
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

