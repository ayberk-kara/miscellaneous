using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            bool secimdogru = false;
            int sayi1, sayi2, sonuc;
            while (secimdogru == false)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:\nToplama için: 1\nÇıkarma için: 2\nÇarpma için: 3\nBölme için: 4\nMod alma: için 5 \nÇıkış için 0: ");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    if (secim <= 5 && secim >= 0)
                    {
                        secimdogru = true;
                        if (secim == 1)
                        {
                            Console.WriteLine("İşlem için birinci sayıyı giriniz: ");
                            sayi1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("İşlem için ikinci sayıyı giriniz: ");
                            sayi2 = Convert.ToInt32(Console.ReadLine());
                            sonuc = sayi1 + sayi2;
                            Console.WriteLine("Sonuç: {0}\nDevam etmek için bir tuşa basınız.", sonuc);
                            Console.ReadKey();
                            secimdogru = false;
                        }
                        else if (secim == 2)
                        {
                            Console.WriteLine("İşlem için birinci sayıyı giriniz: ");
                            sayi1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("İşlem için ikinci sayıyı giriniz: ");
                            sayi2 = Convert.ToInt32(Console.ReadLine());
                            sonuc = sayi1 - sayi2;
                            Console.WriteLine("Sonuç: {0}\nDevam etmek için bir tuşa basınız.", sonuc);
                            Console.ReadKey();
                            secimdogru = false;
                        }
                        else if (secim == 3)
                        {
                            Console.WriteLine("İşlem için birinci sayıyı giriniz: ");
                            sayi1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("İşlem için ikinci sayıyı giriniz: ");
                            sayi2 = Convert.ToInt32(Console.ReadLine());
                            sonuc = sayi1 * sayi2;
                            Console.WriteLine("Sonuç: {0}\nDevam etmek için bir tuşa basınız.", sonuc);
                            Console.ReadKey();
                            secimdogru = false;
                        }
                        else if (secim == 4)
                        {
                            Console.WriteLine("İşlem için birinci sayıyı giriniz: ");
                            sayi1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("İşlem için ikinci sayıyı giriniz: ");
                            sayi2 = Convert.ToInt32(Console.ReadLine());
                            sonuc = sayi1 / sayi2;
                            Console.WriteLine("Sonuç: {0}\nDevam etmek için bir tuşa basınız.", sonuc);
                            Console.ReadKey();
                            secimdogru = false;
                        }
                        else if (secim == 5)
                        {
                            Console.WriteLine("İşlem için birinci sayıyı giriniz: ");
                            sayi1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("İşlem için ikinci sayıyı giriniz: ");
                            sayi2 = Convert.ToInt32(Console.ReadLine());
                            sonuc = sayi1 % sayi2;
                            Console.WriteLine("Sonuç: {0}\nDevam etmek için bir tuşa basınız.", sonuc);
                            Console.ReadKey();
                            secimdogru = false;
                        }
                        else if (secim == 0)
                        { 
                            break;
                        }

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                        secimdogru = false;

                    }

                }
                catch 
                {
                    Console.Clear();
                    Console.WriteLine("Lütfen geçerli bir değer giriniz. Tekrar denemek için bir tuşa basınız.");
                    Console.ReadKey();
                    secimdogru = false;

                }


            }
           
          
        }

    }
}
