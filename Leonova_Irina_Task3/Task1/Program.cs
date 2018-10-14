using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static int AvrLength(string[] words)
        {
            int avr = 0;
            int sum = 0;

            for (int i = 0; i < words.Length; i++)
            {
                sum += words[i].Length;

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
            char[] punktuation = new char[129];

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

            for (int i = 0; i < 128; i++)
            {
                if (char.IsPunctuation((char)i))
                {
                    punktuation[i] = (char)i;
                }

            }
            punktuation[128] = ' ';

            string[] words = text.Split(punktuation, StringSplitOptions.RemoveEmptyEntries);


            avr = AvrLength(words);

            Console.WriteLine($"Средняя длина твоих слов = {avr} А подлиннее можешь?");


        }
    }
}
