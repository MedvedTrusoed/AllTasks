using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    //Написать класс, описывающий треугольник со сторонами a, b, c,
    //и методами, позволяющими осуществить расчёт его площади и периметра.

  
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle t1 = new Triangle(3, 4, 5);

                Console.WriteLine($"Площадь треугольника = {t1.Square} Периметр треугольника = {t1.Perimeter}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
        }
    }
}
