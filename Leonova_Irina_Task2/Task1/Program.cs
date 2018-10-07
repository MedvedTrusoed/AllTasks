using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        //Написать программу, которая генерирует случайным образом элементы массива
        //(число элементов в массиве и их тип определяются разработчиком), 
        //определяет для него максимальное и минимальное значения, 
        //сортирует массив и выводит полученный результат на экран.

        static int Min(int[] randomNumbers, int n)
        {

            int min;
            min = randomNumbers[0];

            for (int i = 0; i < n; i++)
            {

                if (min > randomNumbers[i])
                {

                    min = randomNumbers[i];
                }

            }
            return min;
        }


        static int Max(int[] randomNumbers,int n)
        {
            int max;
            max = randomNumbers[0];

            for (int i = 0; i < n; i++)
            {

                if (max < randomNumbers[i])
                {
                    max = randomNumbers[i];

                }

            }
            return max;
        }


        static int[] sorting(int[] sortedmas, int n)
        {
            int temp; 

            for (int i = 0; i < n; i++)
            {

                for (int k = 0; k < n - 1; k++)
                {

                    if (sortedmas[k] > sortedmas[k + 1])
                    {
                        temp = sortedmas[k];

                        sortedmas[k] = sortedmas[k + 1];

                        sortedmas[k + 1] = temp;

                    }


                }
            }
            return sortedmas;

        }

        static void Print(int[] mas)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{mas[i]}\t");
            }

        }

        static int[] RandNumbs(int n)
        {
            int[] randomNumbers = new int[n];

            Random randNumb = new Random();

            for (int i = 0; i < n; i++)
            {
                randomNumbers[i] = randNumb.Next(100);
            }
            return randomNumbers;
        }

        static void Main(string[] args)
        {
            int[] randomNumbers = new int[10];
            int max;
            int min;
            int n = 10;
            int[] sortedNumb = new int[10];

            try
            {
                randomNumbers = RandNumbs(n);

                Print(randomNumbers);

                max = Max(randomNumbers, n);

                min = Min(randomNumbers, n);

                sortedNumb = sorting(randomNumbers, n);
                //  Array.Sort(randomNumbers);


                Console.WriteLine("Отсортированный массив: ");

                Print(randomNumbers);

                Console.WriteLine($"Максимальный элемент: {max}");

                Console.WriteLine($"Минимальный элемент: {min}");
            }
            catch
            {
                Console.WriteLine($"Произошла ошибка!");
            }
        }
    }
}
