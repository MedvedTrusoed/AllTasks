using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
       
        static void PrintInfo(CultureInfo culture)
        {
            Console.WriteLine(DateTime.Now.ToString(culture));
            Console.WriteLine(culture.NumberFormat.CurrencyGroupSeparator);
        }

        static CultureInfo GetCultureInfoByName(string name)
        {
            return new CultureInfo(name);
        }

        static void Main(string[] args)
        {
            string press = "n";
            do
            {
                string cult = string.Empty;
                // ru-RU  en-US   en-GB
                Console.WriteLine("Введи ru-RU или en-US или en-GB");
                var name = Console.ReadLine();
                var culture = GetCultureInfoByName(name);
                PrintInfo(culture);
                Console.WriteLine("Введи y - чтобы продолжить; n - чтобы закончить");
                press = Console.ReadLine();
            } while (press == "y");
        }
    }
}
