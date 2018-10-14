using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw1 = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();

            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100;

            sw1.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            sw1.Stop();

            sw2.Start();

            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }

            sw2.Stop();

            Console.WriteLine($"Время, затраченное string {sw1.Elapsed}");

            Console.WriteLine($"Время, затраченное StringBuilder {sw2.Elapsed}");
        }
    }
}
