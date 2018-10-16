using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    public class Line : Figure
    {
        private double coordBeginSectionX;
        private double coordEndSectionX;
        private double coordBeginSectionY;
        private double coordEndSectionY;
        private double length;

       public Line(double coordBeginSectionX, double coordBeginSectionY, double coordEndSectionX, double coordEndSectionY)
        {
            if ((coordBeginSectionX == coordEndSectionX) && (coordBeginSectionY == coordEndSectionY))
            {
                throw new Exception("Координаты начала и конца совпадают. Линии не получится!");
            }
            else
            {
                this.coordBeginSectionX = coordBeginSectionX;
                this.coordEndSectionX = coordEndSectionX;
                this.coordBeginSectionY = coordBeginSectionY;
                this.coordEndSectionY = coordEndSectionY;
            }
        }

        public double Length
        {
            get
            {
                double x;
                double y;
                x = LengthSection(coordBeginSectionX, coordEndSectionX);
                y = LengthSection(coordBeginSectionY, coordEndSectionY);

                return Math.Sqrt(Math.Pow(y, 2) + Math.Pow(x, 2));

            }
        }

        public override void Draw()
        {
            Console.WriteLine($"Координаты начала отрезка ({coordBeginSectionX},{coordBeginSectionY})" +
                $" Координаты конца отрезка ({coordEndSectionX},{coordEndSectionY})");
            Console.WriteLine($"Длина отрезка {Length}");
        }

        public double LengthSection(double x1, double x2)
        {
            double x = 0;
            x = Math.Abs(x2 - x1);
            return x;
        }

    }
}
