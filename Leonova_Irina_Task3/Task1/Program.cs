using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static int AvrLength(int[] lengthStr, string[] words)
        {
            int avr = 0;
            int sum = 0;

            for (int i = 0; i < words.Length; i++)
            {
                lengthStr[i] = words[i].Length;

                sum += lengthStr[i];

            }

            avr = sum / words.Length;

            return avr;
        }
        static void Main(string[] args)
        {
            int[] lengthStr = new int[100];
            string text = string.Empty;
            int avr = 0;
            bool check = false;

            Console.WriteLine("Вещайте");

            while (check == false)
            {
                try
                {
                    text = Console.ReadLine();
                    check = true;
                }
                catch
                {
                    Console.WriteLine("Ты сломал меня :с");
                    check = false;
                }
            }
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?', '-', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);


            avr = AvrLength(lengthStr, words);

            Console.WriteLine($"Средняя длина твоих слов = {avr} А подлиннее можешь?");


        }
    }
}
