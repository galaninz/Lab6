using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        /* Ввести с клавиатуры предложение. Предложение представляет собой слова,
         * разделенные пробелом. Знаки препинания не используются.
         * Составить программу, определяющую является ли строка палиндромом
         * без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).
         */
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str = str.ToLower();
            str = str.Replace(" ", "");
            Console.WriteLine(str);
            string[] strArray = str.Split();
            string str2 = "";
            foreach (char c in str)
            {
                str2 = c + str2;
            }
            Console.WriteLine(str2);
            /* for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    Console.WriteLine("Не палиндром");
                    break;
                }
                else
                {
                    Console.WriteLine("Палиндром");
                    break;
                }
            }
            */
            if (string.Compare(str, str2) == 0)
            {
                Console.WriteLine("Палиндром");
            }
            else
            {
                Console.WriteLine("Не палиндром");
            }
            Console.ReadKey();
        }
    }
}
