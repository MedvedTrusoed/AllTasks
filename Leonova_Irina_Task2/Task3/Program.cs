using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        //Написать программу, которая определяет сумму неотрицательных элементов в одномерном массиве.
      
            //static int[] ReadElementsOfArr(int n)
        //{
        //    int[] arr = new int[n];

        //    for (int i = 0; i < n; i++)
        //    {
        //        arr[i] = Console.Read();
        //    }
        //    return arr;
        //}

        static int SumPlasElement(int[] arr,int n)
        {
            int sum=0;
            for (int i = 0;i<n;i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
                
            return sum;
        }
       

        static void Main(string[] args)
        {
            int n = 10;
            int sum = 0;
            try
            {
                //  int[] arr = new int[n];
                //  arr = ReadElementsOfArr(n);

                int[] arr = { 1, -2, 3, 4, -5, 6, -7, 8, 9, -10 };

                sum = SumPlasElement(arr, n);

                Console.WriteLine($" Сумма неотрицательных элементов = {sum}");
            }
            catch
            {
                Console.WriteLine($"Произошла ошибка!");
            }
        }
    }
}
