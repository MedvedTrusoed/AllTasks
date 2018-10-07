using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        //Написать программу, которая запрашивает с клавиатуры число N
        //и выводит на экран следующее «изображение», состоящее из N строк:
        //Треугольник рисует

        static void Space(int N)
        {
            var s = string.Empty;

            while (N > 0)
            {
                s+=" ";
                N--;
            }
            Console.Write(s);
            s = string.Empty;
        }

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
            var s = string.Empty;
            int N;
            bool inputError = false;

            try
            {
                Console.WriteLine("Введи N: ");
                do
                {
                    N = int.Parse(Console.ReadLine());
                    inputError = Err(N);
                } while (inputError == true);


                int countSpace = N;


                for (int i = 1; i <= N; i++) // строки
                {
                    int countStar = i * 2 - 1;
                    Space(countSpace);
                    countSpace--;
                    while (countStar > 0)
                    {
                        countStar--;
                        s += "*";
                        
                    }
                    Console.Write($"{s}");
                    Console.WriteLine();
                    s=string.Empty;
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("ОЙ! Кажется что-то пошло не так!");
                Console.ReadKey();
            }

        }
    }
}
