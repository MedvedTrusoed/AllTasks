using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        //Написать программу, которая запрашивает с клавиатуры число N
        //и выводит на экран следующее «изображение», состоящее из N строк:
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
            int N;
            bool inputError = false;
            var s = string.Empty;
           

            try
            {
                Console.WriteLine("Введи N: ");
                do
                {
                    N = int.Parse(Console.ReadLine());
                    inputError = Err(N);
                } while (inputError == true);

                
                for (int i = 1; i <= N; i++)
                {
                    int count = i;

                    // var s = new string('*', count);

                    while (count > 0)
                    {
                        count--;
                        s += "*";
                    }
                    Console.WriteLine(s);
                    s = string.Empty;
                }
               

            }

            catch
            {
                Console.WriteLine("ОЙ! Кажется что-то пошло не так!");
                Console.ReadKey();
            }
        }
    }
}
