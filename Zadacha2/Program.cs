using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string resultString = "";
            int f = 0;
            foreach (string s in stringArray)
            {
                resultString += s.Substring(0, 1).ToLower() + s.Substring(1);
            }
            for (int i = 0, j = resultString.Length - 1; i < resultString.Length; i++, j--)
            {
                if (resultString[i] != resultString[j] && i != j)
                {
                    f = 1;
                }
            }
            if (f == 0)
                Console.WriteLine("{0},{1}", startString, "Полиндром");
            else Console.WriteLine("{0},{1}", startString, "Не полиндром");
            Console.ReadLine();
        }
    }
}