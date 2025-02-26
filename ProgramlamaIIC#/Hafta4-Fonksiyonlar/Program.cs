using System;

namespace Hafta4_Fonksiyonlar
{
    internal class Program
    {
        static void Selamlama()
        {
            Console.WriteLine("Merhaba");
        }
        static void Selamlama(string ad)
        {
            Console.WriteLine($"Merhaba {ad}");
        }
        static void Selamlama(int ad)
        {
            Console.WriteLine($"Yaşım {ad}");

        }
        static void Main(string[] args)
        {
            Selamlama();
            Selamlama("Yudum");
            Selamlama(18);
            int sonuc = Toplam(2, 4);
            // Console.WriteLine(sonuc);
            //Console.WriteLine($"Sonuc 1 :{Toplam(2.1f, 3)}");
            //Console.WriteLine($"Sonuc 2 :{Toplam(4, 6.2f)}");
            //Console.WriteLine($"Sonuc 3 :{Toplam(b:(int)6.5f, a:8)}");
            //Console.WriteLine($"Sonuç {Carpma(2, 3)}");
            //Console.WriteLine($"Sonuç {Carpma(2)}");
            //Console.WriteLine($"Sonuç {Carpma(2)}");
            //Console.WriteLine($"Sonuç {Bolme(2)}");
            //Console.WriteLine($"Sonuç {Bolme(a:2)}");
            //Console.WriteLine($"Sonuç {Bolme(b: 2)}");
            //Console.WriteLine($"Sonuç {Bolme(b: 2, a: 5)}");
            //Console.WriteLine($"Sonuç {Bolme( 2, 5)}");
            Console.WriteLine($"Sonuç{Faktoriyel(5)}");
        }
        static int Toplam(int a, int b)
        {
            Console.WriteLine("int a int b");
            return a + b;
        }
        static float Toplam(float a, int b)
        {
            Console.WriteLine("float a int b");
            return a + b;
        }
        static float Toplam(int a, float b)
        {
            Console.WriteLine("int a float b");
            return a + b;
        }
        static int Carpma(int a, int b = 1)
        {
            return a * b;
        }
        static float Bolme(int a = 1, float b = 1)
        {
            return a / b;
        }
        static int Faktoriyel(int y)
        {
            int sonuc = 1;
            for (int i = 1; i <= y; i++)
            {
                sonuc *= i;
            }
            return sonuc;

        }
        static int RecFaktoriyel(int y)
        {
            if (y == 1 || y == 0)
                return 1;
            else
            {
                return y * RecFaktoriyel(y - 1);
            }
        }
    }
}
