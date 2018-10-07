using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        //Написать программу, которая запрашивает с клавиатуры число N
        //и выводит на экран следующее «изображение», состоящее из N треугольников:
        //Несколько треугольников рисует

        static void Space(int N)
        {
            var s = string.Empty;

            while (N > 0)
            {
                s += " ";
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

        static void Triangle(int countTriangls, int countSpace)
        {
            int N = countTriangls;
            var s = string.Empty;
            
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
                s = string.Empty;
            }
            
        }

        static void Main(string[] args)
        {
            int CountTriangls=-1;
            int N;
            int formTriangle = 0;
            bool inputError = false;

            try
            {
                Console.WriteLine("Введи Количество треугольников N: ");
                do
                {
                    N = int.Parse(Console.ReadLine());
                    inputError = Err(N);
                } while (inputError == true);


                int countSpace = N;
                int temp = 0;

                while (CountTriangls!=N) {

                    formTriangle = N - temp - 1;
                    CountTriangls = N - formTriangle;

                    temp++;
                    Triangle(CountTriangls, countSpace);

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
