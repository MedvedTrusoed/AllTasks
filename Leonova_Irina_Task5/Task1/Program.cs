using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee u1 = new Employee();
                u1.Name = "Pavel";
                u1.Surname = "Gnomik";
                DateTime d1 = new DateTime(1998, 7, 20);
                u1.Birthday = d1;
                u1.DataWork = new DateTime(2015, 09, 05);
                u1.Position = "Programmer";

                Console.WriteLine($"Имя {u1.Name} фамилия {u1.Surname} возраст {u1.Age}");
                Console.WriteLine($"Должность {u1.Position} Стаж {u1.Experience}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
        }
    }
}
