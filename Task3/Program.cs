using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Дана строка S. Из строки требуется удалить текст, заключенный в {фигурные скобки}. В строке может быть несколько фрагментов, заключённых в {фигурные скобки}. Возможно использование вложенных {фигурных скобок}, необходимо, чтобы программа это учитывала.";
            // Про вложенные скобки не понял. Это {a{a}a} верно? Если да, то эта программа удалит все между первой и последней скобкой. Либо куча этажей if на проверку Substring.
            string[] strArray = str.Split();
            Console.WriteLine(str);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '{')
                {
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (str[j] == '}')
                        {
                            str = str.Substring(0, i + 1) + str.Substring(j);
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
