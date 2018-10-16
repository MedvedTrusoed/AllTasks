using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Ring : Figure
    {
        private float x;
        private float y;
        private double innerRadius;
        private double outherRadius;

        public Ring(float x, float y, double innerRadius, double outherRadius) 
        {
            if (innerRadius > outherRadius)
            {
                throw new Exception("Внутренний радиус должен быть поменьше :с");
            }
            else if (innerRadius <= 0 || outherRadius <= 0)
            {
                throw new Exception("Таких радиусов не бывает");
            }

            else
            {
                this.innerRadius = innerRadius;
                this.outherRadius = outherRadius;
                this.x = x;
                this.y = y;
            }
        }

      
        public double SquadRing
        {
            get
            {
                return Math.Round((Math.Pow(outherRadius, 2) * Math.PI) - (Math.Pow(innerRadius, 2) * Math.PI));
            }
        }

        public double SumLength
        {
            get
            {
                return Math.Round((outherRadius * 2 * Math.PI) + (innerRadius * 2 * Math.PI));
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"Сумма длин окружностей = {SumLength} Площадь диска = {SquadRing}");
        }

    }
}

