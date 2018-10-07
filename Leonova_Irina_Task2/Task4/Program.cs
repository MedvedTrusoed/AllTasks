using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        //Элемент двумерного массива считается стоящим на чётной позиции,
        //если сумма номеров его позиций по обеим размерностям является чётным числом
        //(например, [1,1] – чётная позиция, а[1, 2] - нет). 
        //Определить сумму элементов массива, стоящих на чётных позициях.

        //static int[,] ReadElementsOfArr(int n)
        //{
        //    int[,] arr = new int[n, n];

        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            arr[i, j] = Console.Read();
        //        }
        //    }
        //    return arr;
        //}

        static void PrintArr(int[,] arr, int n,int m)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    Console.Write($"{arr[i, j]} ");
                }

                Console.WriteLine();
            }
        }

        static int SumEven(int[,] arr, int n, int m)
        {
            int sum = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += arr[i, j];
                    }
                }
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int n = 5;
            int m = 2;

            int sum = 0;

            // int[,] arr = new int[n,m];

           int[,] arr = { { 1, -2, 3, 4, -5 }, { 6, -7, 8, 9, -10 } };

            try
            {

                PrintArr(arr, n, m);

                sum = SumEven(arr, n, m);

                Console.WriteLine($" Сумма четных элементов = {sum}");
            }
            catch
            {
                Console.WriteLine($" Произошла ошибка ");
            }

        }
    }
}
