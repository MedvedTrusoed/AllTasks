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
            string secondStr = string.Empty;
            string simbol = string.Empty;


            Console.WriteLine("Ну давай, удиви меня");

            firstStr = Console.ReadLine();

            firstStr = firstStr.ToLower();

            Console.WriteLine("Продолжай удивлять");

            secondStr = Console.ReadLine();

            secondStr = secondStr.ToLower();

            secondStr = secondStr.Replace("  ", string.Empty);  

            char[] arrSecondStr = secondStr.Distinct().ToArray();

            try
            {
                for (int i = 0; i < arrSecondStr.Length; i++)
                {
                    if (firstStr.Contains(arrSecondStr[i]))
                    {
                        simbol = arrSecondStr[i].ToString();

                        firstStr = firstStr.Replace(simbol, simbol + simbol);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Я сломался");
            }
            Console.WriteLine(firstStr);
            Console.ReadKey();

        }
    }
}
