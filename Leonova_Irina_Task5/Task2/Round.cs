using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Round
    {
        private double radius;
        private float centerX;
        private float centerY;
        private float centerZ;

        public Round(float x, float y, float z)
        {      
                centerX = x;
                centerY = y;
                centerZ = z;

        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
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
}
