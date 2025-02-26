using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            String[] strings = { "Deve", "Çokbilen", "Boksör", "Kedi", "Rizeli" };
            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }
            foreach (string s in strings)
            {
                Console.WriteLine(s + " Araba");
            }
            switch (a)
            {
                case 0:
                    Console.WriteLine(a);
                    break;
                default:
                    Console.WriteLine(a);
                    break;
            }

        }
    }
}
