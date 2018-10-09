using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstStr = string.Empty;
            string copyFirstStr = string.Empty;
            string secondStr = string.Empty;
         
            string simbol = string.Empty;
            string removeFirstStr = string.Empty;
            int[] indexOfChar = new int[100];
            int count = 0;
            int temp = 2;
            int enter = 0;
            int min = 99;

            Console.WriteLine("Ну давай, удиви меня");

            firstStr = Console.ReadLine();

            copyFirstStr = firstStr;

            firstStr = firstStr.ToLower();

            removeFirstStr = firstStr;

            Console.WriteLine("Продолжай удивлять");

            secondStr = Console.ReadLine();

            secondStr = secondStr.ToLower();

            secondStr = secondStr.Replace("  ", string.Empty);

            char[] arrSecondStr = secondStr.ToCharArray();

            for (int i = 0; i < arrSecondStr.Length; i++)
            {

                min = indexOfChar[0];
                simbol = arrSecondStr[i].ToString();

                if (removeFirstStr.IndexOf(arrSecondStr[i]) < min)
                {
                    enter = 0;
                    temp += 2;
                }
                while (removeFirstStr.IndexOf(arrSecondStr[i]) != -1)

                {
                    if (enter == 0)
                    {
                        enter = 1;

                        indexOfChar[count] = removeFirstStr.IndexOf(arrSecondStr[i]);
                        removeFirstStr = removeFirstStr.Remove(indexOfChar[count], 1);
                        copyFirstStr = copyFirstStr.Insert(indexOfChar[count], simbol);
                        count++;

                    }
                    else
                    {
                        enter = 1;
                        indexOfChar[count] = removeFirstStr.IndexOf(arrSecondStr[i]) + temp;

                        removeFirstStr = removeFirstStr.Remove(removeFirstStr.IndexOf(arrSecondStr[i]), 1);

                        copyFirstStr = copyFirstStr.Insert(indexOfChar[count], simbol);
                        temp += 2;
                        count++;
                    }
                }


            }


         // Console.WriteLine(firstStr);
            Console.WriteLine(copyFirstStr);

        }
    }
}
