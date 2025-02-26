using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramlamaIIC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 7;
            Math.Pow(2, 32);
            Console.WriteLine(Math.Pow(2, 32));

            string isim = "Enes";
            isim.ToUpper();
            Console.WriteLine(isim.ToUpper());
            Console.WriteLine(isim == isim.ToUpper());
            Console.WriteLine(isim.ToLower());
            bool check = isim.ToUpper() == isim;
            Console.WriteLine(check);
            bool check2 = isim.ToLower() == isim && sayi > 9;
            Console.WriteLine(check2);
            bool check3 = isim.ToLower() == isim || sayi < 9;
            Console.WriteLine(check3);
            /*string inputt = Console.ReadLine();
            Console.WriteLine(inputt);*/
            /*int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi1 * sayi2);*/
            int sayi1 = 0, sayi2 = 0;
            try
            {
                sayi1 = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("Hata Ayıklandı");
                sayi1 = -1;
            }

            try
            {
                sayi2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e + "Hata Ayıklandı");
            }
            Console.WriteLine(sayi1 * sayi2);
        }
    }
}
