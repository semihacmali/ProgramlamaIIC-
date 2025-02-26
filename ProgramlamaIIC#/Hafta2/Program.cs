using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Hesap Makinesi Örneği
namespace Hafta2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi, sayi2, sonuc = 0.0d;

            int islem = 0;
            bool dogruSayi = false;
            while (islem != 5)
            {
                Console.WriteLine("İşlem Türü Seçiniz:\n 1-Toplama\n 2-Çıkarma\n 3-Çarpma\n 4-Bölme\n 5-Çıkış");
                islem = Convert.ToInt32(Console.ReadLine());

                if (islem == 5)
                {
                    break;
                }

                do
                {
                    try
                    {
                        Console.Write("Birinci sayı giriniz: ");
                        sayi = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch
                    {

                        Console.Write("Birinci sayiyi Hatalı girdiniz!\n");
                        sayi = 0;
                    }

                } while (!dogruSayi);

                dogruSayi = false;
                do
                {
                    try
                    {
                        Console.Write("İkinci sayı giriniz: ");
                        sayi2 = Convert.ToDouble(Console.ReadLine());
                        dogruSayi = true;
                    }
                    catch
                    {
                        Console.Write("İkinci sayiyi Hatalı girdiniz!\n");
                        sayi2 = 0;
                    }
                } while (!dogruSayi);





                if (islem == 1)

                    sonuc = sayi + sayi2;

                else if (islem == 2)

                    sonuc = sayi - sayi2;

                else if (islem == 3)
                {

                    sonuc = sayi * sayi2;
                }

                else if (islem == 4)
                {
                    while (sayi2 == 0)
                    {
                        dogruSayi = false;
                        do
                        {
                            try
                            {
                                Console.Write("İkinci sayı giriniz: ");
                                sayi2 = Convert.ToDouble(Console.ReadLine());
                                dogruSayi = true;
                            }
                            catch
                            {
                                Console.Write("İkinci sayiyi Hatalı girdiniz!\n");
                                sayi2 = 0;
                            }
                        } while (!dogruSayi);
                    }
                    sonuc = sayi / sayi2;
                }




                else

                    Console.WriteLine("Hatalı İşlem Seçimi Yaptınız: ");


                Console.WriteLine("İşlem Sonucunuz: " + sonuc);

            }


        }
    }
}
    

