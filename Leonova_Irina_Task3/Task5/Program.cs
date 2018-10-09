using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string htmlStr = string.Empty;

            Console.WriteLine("Введи HTML - текст");

            htmlStr = Console.ReadLine();

            //string htmlStr2 = "< b> Это </ b > текст < i > с </ i > <font color =”red”> HTML </ font > кодами";

            htmlStr = Regex.Replace(htmlStr, @"<.*?> | <\/.*?> ", "_");

            //htmlStr2 = Regex.Replace(htmlStr2, @"<.*?> | <\/.*?> ", "_");

            //Console.WriteLine(htmlStr2);

            Console.WriteLine(htmlStr);
        }
    }
}
