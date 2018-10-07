using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        // Написать программу, которая заменяет все положительные элементы в трёхмерном массиве на нули.

        static void Print(int[,,] threeArr)
        {

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {

                        Console.Write($"{threeArr[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

       static int[,,] NoPlas(int[,,] threeArr)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (threeArr[i, j, k] > 0)
                        {
                            threeArr[i, j, k] = 0;
                        }
                        
                    }
                    
                }
                
            }
            return threeArr;
        }
    

        static void Main(string[] args)
        {           

         //   трехмерный массив 2x3x3

            int[,,] threeArr = {
                   {
                       { -1, 2, 3 },
                       { -5, -6, 7 },
                       { -9, 8, -4}
                   },
                   {
                       {-13, 3, -15},
                       { -7, 6, 19},
                       { 1, -4, 23}
                   }
               };

            try
            {
                Print(threeArr);

                threeArr = NoPlas(threeArr);

                Print(threeArr);
            }
            catch
            {
                Console.WriteLine("Произошла ошибка!");
            }
        }
    }
}
