using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        //Если выписать все натуральные числа меньше 10, кратные 3, или 5, 
        //то получим 3, 5, 6 и 9. Сумма этих чисел будет равна 23.
        //Напишите программу, которая выводит на экран сумму всех чисел меньше 1000, кратных 3, или 5.

        static int Sum()
        {
            int sum = 0;
            int n = 0;

            while (n < 1000)
            {
                if (n % 3 == 0 || n % 5 == 0)
                {
                    sum += n;

                }
                n++;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            
            int sum = 0;
            try
            {

                sum = Sum();

                Console.WriteLine($"Сумма чисел кратных 3 или 5 = {sum}");
            }
            catch
            {
                Console.WriteLine($"Кажется что-то сломалось");
            }
        }
    }
}
