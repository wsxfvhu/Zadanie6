using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слова через пробел: ");
            string input = Console.ReadLine();
            string[] str = input.Split();
            int maxLen = 0, index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxLen)
                {
                    maxLen = str[i].Length;
                    index = i;
                }
            }
            Console.Write("Самое длинное слово: {0}", str[index]);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length == maxLen && i != index)
                {
                    Console.Write(" и {0}", str[i]);
                }
            }
            Console.ReadLine();
        }
    }
}