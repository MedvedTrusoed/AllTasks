using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Rectangle : Figure
    {
        private float x1;
        private float y1;
        private float x2;
        private float y2;

        //Координаты лево низ и право верх или наоборот

        public Rectangle(float x1, float y1, float x2, float y2)
        {
            if ((x1 == x2) || (y1 == y2))
            {
                throw new Exception("Координаты начала и конца совпадают. Прямоугольник не получится!");
            }
            else
            {
                this.x1 = x1;
                this.y1 = y1;
                this.x2 = x2;
                this.y2 = y2;
            }

        }

        public double Square
        {
            get
            {
                double x;
                double y;

                x = LengthSection(x1, x2);
                y = LengthSection(y1, y2);

                return x * y;
            }
        }

        public double Perimetr
        {
            get
            {
                double x;
                double y;

                x = LengthSection(x1, x2);
                y = LengthSection(y1, y2);

                return (x + y) * 2;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"Площадь квадрата = {Square} ");
        }

        public double LengthSection(double x1, double x2)
        {
            double x = 0;
            x = Math.Abs(x2 - x1);
            return x;
        }

    }
}
