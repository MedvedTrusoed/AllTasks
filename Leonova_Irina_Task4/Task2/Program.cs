using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //Написать класс Round, задающий круг с указанными координатами центра,
    //радиусом, а также свойствами, позволяющими узнать длину описанной окружности и площадь круга.
   
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Round r1 = new Round(0,0,0);
                r1.Radius = 2;

                Console.WriteLine($"Площадь круга {r1.Squad} Длина окружности {r1.Length}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
        }
    }
}
