using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Area_Perimeter_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validgiris = false, validsekil = false, validucgentipi= false, validislemturu = false;
            int secimsekil = 0;

            try
            {
                while (validgiris == false)
                {
                    validgiris = false;
                    validsekil = false;
                    validucgentipi = false;
                    validislemturu = false;
                    Console.Write("Hesaplama yapmak için 1 çıkmak için 0 yazınız: ");
                    int secim = Convert.ToInt16(Console.ReadLine());
                    if (secim == 1)
                    {
                        while (validislemturu == false)
                        {
                            Console.Write("Alan hesaplamak için 1 çevre hesaplamak için 2 yazınız: ");
                            int secimislem = Convert.ToInt16(Console.ReadLine());
                            if (secimislem == 1)
                            {
                                while (validsekil == false)
                                {
                                    Console.Write("Üçgen için 1\nKare için 2\nDikdörtgen için 3\nDaire için 4 yazınız: ");
                                    secimsekil = Convert.ToInt16(Console.ReadLine());
                                    if (secimsekil == 1)
                                    {
                                        Console.Write("Eşkenar üçgen için 1\nİkizkenar üçgen için 2\nÇeşitkenar üçgen için 3 yazınız:");
                                        int secimucgentipi = Convert.ToInt16(Console.ReadLine());
                                        while (validucgentipi == false)
                                        {
                                            if (secimucgentipi == 1)
                                            {
                                                Console.Write("Üçgenin bir kenarını yazınız: ");
                                                double eskenarkenar = Convert.ToDouble(Console.ReadLine());
                                                double sonuc = eskenarkenar * eskenarkenar * Math.Pow(3, 0.5) * 0.25; ;                                         
                                                Console.WriteLine("Eşkenar üçgenin alanı: {0}", sonuc);
                                                validislemturu = false;
                                                validucgentipi = true;
                                            }
                                            else if (secimucgentipi == 2)
                                            {
                                                Console.Write("İkizkenar üçgenin eşkenarlarından birini yazınız: ");
                                                double ikizkenareskenar = Convert.ToDouble(Console.ReadLine());
                                                Console.Write("İkizkenar yüksekliğini yazınız: ");
                                                double ikizkenaryukseklik = Convert.ToDouble(Console.ReadLine());
                                                double sonuc = ikizkenareskenar * ikizkenaryukseklik * 0.5;
                                                Console.WriteLine("İkizkenar üçgenin alanı: {0}", sonuc);
                                                validucgentipi = true;
                                                validislemturu = false;
                                            }
                                            else if (secimucgentipi == 3)
                                            {
                                                Console.Write("Çeşitkenar üçgenin 1. kenarını giriniz: ");
                                                double cesitkenar1 = Convert.ToDouble(Console.ReadLine());
                                                Console.Write("Çeşitkenar üçgenin 1. kenarına ait yükseliğini giriniz: ");
                                                double cesitkenaryukseklik = Convert.ToDouble(Console.ReadLine());
                                                double sonuc = cesitkenaryukseklik * cesitkenar1 * 0.5;
                                                Console.WriteLine("Çeşitkenar üçgenin alanı: {0}", sonuc);
                                                validucgentipi = true;
                                                validislemturu = false;

                                            }
                                            else
                                            {
                                                Console.WriteLine("Yanlış üçgen tipi seçimi yaptınız tekrar deneyiniz.");
                                                validucgentipi = false;
                                            }
                                        }
                                        validsekil = true;
                                    }
                                    else if (secimsekil == 2)
                                    {
                                        Console.Write("Karenin bir kenarını yazınız: ");
                                        double karekenar = Convert.ToDouble(Console.ReadLine());
                                        double sonuc = karekenar * karekenar;
                                        Console.WriteLine("Karenin alanı: {0}", sonuc);
                                        validsekil = true;
                                        validislemturu = false;
                                    }
                                    else if (secimsekil == 3)
                                    {
                                        Console.Write("Dikdörtgenin bir kenarını yazınız: ");
                                        double dikdörtgen1 = Convert.ToDouble(Console.ReadLine());
                                        Console.Write("Dikdörtgenin diğer kenarını yazınız: ");
                                        double dikdörtgen2 = Convert.ToDouble(Console.ReadLine());
                                        double sonuc = dikdörtgen2 * dikdörtgen1;
                                        Console.WriteLine("Dikdörtgenin alanı: {0}", sonuc);
                                        validsekil = true;
                                        validislemturu = false;
                                    }
                                    else if (secimsekil == 4)
                                    {
                                        Console.Write("Dairenin yarıçapını yazınız: ");
                                        double daireninyaricapi = Convert.ToDouble(Console.ReadLine());
                                        double sonuc = daireninyaricapi * daireninyaricapi * Math.PI;
                                        Console.WriteLine("Dairenin alanı: {0}", Math.Round(sonuc,2));
                                        validsekil = true;
                                        validislemturu = false;
                                    }
                                    else
                                    {
                                        validsekil = false;
                                    }

                                }
                                validislemturu = true;
                            }
                            else if (secimislem == 2)
                            {
                                while (validsekil == false)
                                {
                                    Console.Write("Üçgen için 1\nKare için 2\nDikdörtgen için 3\nDaire için 4 yazınız: ");
                                    secimsekil = Convert.ToInt16(Console.ReadLine());
                                    if (secimsekil == 1)
                                    {
                                        Console.Write("Eşkenar üçgen için 1\nİkizkenar üçgen için 2\nÇeşitkenar üçgen için 3 yazınız:");
                                        int secimucgentipi = Convert.ToInt16(Console.ReadLine());
                                        while (validucgentipi == false)
                                        {
                                            if (secimucgentipi == 1)
                                            {
                                                Console.Write("Üçgenin bir kenarını yazınız: ");
                                                double eskenarkenar = Convert.ToDouble(Console.ReadLine());
                                                double sonuc = eskenarkenar * 3;
                                                Console.WriteLine("Eşkenar üçgenin çevresi: {0}", sonuc);
                                                validucgentipi = true;
                                                validislemturu = false;
                                            }
                                            else if (secimucgentipi == 2)
                                            {
                                                Console.Write("İkizkenar üçgenin eşkenarlarından birini yazınız: ");
                                                double ikizkenareskenar = Convert.ToDouble(Console.ReadLine());
                                                Console.Write("İkizkenar üçgenin diğerini yazınız: ");
                                                double ikizkenardigerkenar = Convert.ToDouble(Console.ReadLine());
                                                double sonuc = ikizkenareskenar + ikizkenardigerkenar + ikizkenareskenar;                 
                                                Console.WriteLine("İkizkenar üçgenin çevresi: {0}", sonuc);
                                                validucgentipi = true;
                                                validislemturu = false;
                                            }
                                            else if (secimucgentipi == 3)
                                            {
                                                Console.Write("Çeşitkenar üçgenin 1.kenarını giriniz: ");
                                                double cesitkenar1 = Convert.ToDouble(Console.ReadLine());
                                                Console.Write("Çeşitkenar üçgenin 2.kenarını giriniz: ");
                                                double cesitkenar2 = Convert.ToDouble(Console.ReadLine());
                                                Console.Write("Çeşitkenar üçgenin 3.kenarını giriniz: ");
                                                double cesitkenar3 = Convert.ToDouble(Console.ReadLine());
                                                double sonuc = cesitkenar3 + cesitkenar2 + cesitkenar1;                 
                                                Console.WriteLine("Çeşitkenar üçgenin çevresi: {0}", sonuc);
                                                validucgentipi = true;
                                                validislemturu = false;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Yanlış üçgen tipi seçimi yaptınız tekrar deneyiniz.");
                                                validucgentipi = false;
                                                validislemturu = false;
                                            }
                                        }
                                        validsekil = true;
                                    }
                                    else if (secimsekil == 2)
                                    {
                                        Console.Write("Karenin bir kenarını yazınız: ");
                                        double karekenar = Convert.ToDouble(Console.ReadLine());
                                        double sonuc = karekenar * 4;
                                        Console.WriteLine("Karenin çevresi: {0}", sonuc);
                                        validsekil = true;
                                        validislemturu = false;
                                    }

                                    else if (secimsekil == 3)
                                    {
                                        Console.Write("Dikdörtgenin bir kenarını yazınız: ");
                                        double dikdörtgen1 = Convert.ToDouble(Console.ReadLine());
                                        Console.Write("Dikdörtgenin diğer kenarını yazınız: ");
                                        double dikdörtgen2 = Convert.ToDouble(Console.ReadLine());
                                        double sonuc = dikdörtgen2 + dikdörtgen1 + dikdörtgen2 + dikdörtgen1;
                                        Console.WriteLine("Dikdörtgenin çevresi: {0}", sonuc);
                                        validsekil = true;
                                        validislemturu = false;
                                    }
                                    else if (secimsekil == 4)
                                    {
                                        Console.Write("Dairenin yarıçapını yazınız: ");
                                        double daireninyaricapi = Convert.ToDouble(Console.ReadLine());
                                        double sonuc = daireninyaricapi * 2 * Math.PI;
                                        Console.WriteLine("Dairenin çevresi: {0}", Math.Round(sonuc,2));
                                        validsekil = true;
                                        validislemturu = false;
                                    }
                                    else
                                    {
                                        validsekil = false;
                                    }

                                }
                                validislemturu = true;

                            
                            }
                            else
                            {
                                Console.WriteLine("Hatalı işlem türü girdiniz.");
                                validislemturu = false;
                            }

                        }

                    }

                    else
                    {
                        break;
                    }


                }


            }
            catch
            {
                Console.WriteLine("Bir sayı değeri girmediniz. Program sonlandırılıyor.");
                Console.ReadKey();
                
            }
   

        }
    }
}
