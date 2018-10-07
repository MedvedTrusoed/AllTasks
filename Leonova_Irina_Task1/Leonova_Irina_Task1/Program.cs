using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        //Написать программу, которая определяет площадь прямоугольника со сторонами a и b.
        //Если пользователь вводит некорректные значения(отрицательные, или 0), 
        //должно выдаваться сообщение об ошибке.
        //Возможность ввода пользователем строки вида «абвгд», или нецелых чисел игнорировать.


        static bool Err(int temp)
        {
            bool wrong = false;

            if (temp <= 0)
            {
                wrong = true;
                Console.WriteLine("Некорректное значение, попробуй еще раз");
            }
            return wrong;
        }

        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int S = 0;

            do
            {
                try
                {
                    Console.WriteLine("Введи а: ");
                    a = int.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("ОЙ! Кажется вы ввели что-то не то");
                    Console.ReadKey();
                }
            } while (Err(a));


            do
            {
                try
                {
                    Console.WriteLine("Введи b: ");
                    b = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("ОЙ! Кажется вы ввели что-то не то");
                    Console.ReadKey();
                }

            } while (Err(b));

            try
            {
                S = a * b;
                Console.WriteLine($"Площадь = {S}");
            }
            catch
            {
                Console.WriteLine("Не могу посчитать площадь :с ");
            }
        }

    }
}

