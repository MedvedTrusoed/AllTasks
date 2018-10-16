using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Task4;

namespace Task1
{
    //Написать класс User, описывающий человека(Фамилия, Имя, Отчество, Дата рождения, Возраст). 
    //Написать программу, демонстрирующую использование этого класса


    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User u1 = new User();
                u1.Name = "Кузьма";
                u1.Surname = "Кукуев";
                DateTime d1 = new DateTime(2001, 08, 01);
                u1.Birthday = d1;

                Console.WriteLine($"Имя {u1.Name} Фамилия {u1.Surname} Возраст {u1.Age}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
        }
    }
}
