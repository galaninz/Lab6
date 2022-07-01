using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Program
    {
        /*Ввести с клавиатуры предложение. Предложение представляет собой слова,
         * разделенные пробелом. Знаки препинания не используются.
         * Найти самое длинное слово в строке.
         */
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArray = str.Split();
            string max = strArray[0];
            foreach (string s in strArray)
            {
                if (s.Length > max.Length)
                {
                    max = s;
                }
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
