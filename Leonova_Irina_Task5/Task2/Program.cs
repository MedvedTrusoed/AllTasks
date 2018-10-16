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
            try
            {
                Ring r1 = new Ring(0,0,0);
                r1.Radius = 2;
                r1.InnerRadius = 1;

                Console.WriteLine($"Площадь кольца = {r1.SquadRing} Суммарная длина окружностей = {r1.SumLength}");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
        }
    }

   
}