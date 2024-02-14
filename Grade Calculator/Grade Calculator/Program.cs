using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator
{
    internal class Program
    {
        public static string harfnotual (double not)
        {
            string harfnotu="";
            if (not >= 90 && not <= 100)
            {
                harfnotu = "AA";
            }
            if (not >= 85 && not <= 89)
            {
                harfnotu = "BA";
            }
            if (not >= 80 && not <= 84)
            {
                harfnotu = "BB";
            }
            if (not >= 75 && not <= 79)
            {
                harfnotu = "CB";
            }
            if (not >= 65 && not <= 74)
            {
                harfnotu = "CC";
            }
            if (not >= 58 && not <= 64)
            {
                harfnotu = "DC";
            }
            if (not >= 50 && not <= 57)
            {
                harfnotu = "DD";
            }
            if (not >= 40 && not <= 49)
            {
                harfnotu = "FD";
            }
            if (not <= 39)
            {
                harfnotu = "FF";
            }


            return (harfnotu);
        }

        static void Main(string[] args)
        {
			bool secimdogru = false, degerlerdogru = false;			
			while (secimdogru == false)
			{
				try
				{
                    Console.Write("Not hesaplamak için H, çıkış yapmak için E yazınız.");
                    char secenek = Convert.ToChar(Console.ReadLine());
                    if (secenek == 'E' || secenek == 'e')
                    {
                        break;
                    }
                    else if (secenek == 'H' || secenek == 'h')
                    {
                        while (degerlerdogru == false)
                        {
                            try
                            {
                                Console.Write("Hesaplamak istediğiniz dersin adını giriniz: ");
                                string dersadi = Console.ReadLine();
                                Console.Write("Lütfen girmek istediğiniz not adedini giriniz: ");
                                int notadedi = Convert.ToInt32(Console.ReadLine());
                                double yüzdetoplam = 0;
                                double not = 0;                             
                                for (int i = 1; i < notadedi+1; i++)
                                {
                                    try
                                    {
                                        if (not < 100)
                                        {

                                            Console.Write("{0}. notunuzu giriniz:", i);
                                            double not1 = Convert.ToDouble(Console.ReadLine());


                                            if (not1<=100 || not1<0)
                                            {
                                                Console.Write("{0}. notunuzun yüzdesini giriniz: ", i);
                                                double yüzde = Convert.ToDouble(Console.ReadLine());
                                                yüzdetoplam += yüzde;
                                                if (yüzdetoplam > 100)
                                                {
                                                    yüzdetoplam -= yüzde;
                                                    Console.WriteLine("Yüzde değeri 100'den fazla olamaz! Kalan yüzde hakkınız {0}'dır", 100 - yüzdetoplam);
                                                    i--;
                                                }
                                                else
                                                {
                                                    not += (not1 * (yüzde/100));
                                                    if (yüzdetoplam == 100)
                                                    {
                                                        string durum = "";
                                                        if (not > 50)
                                                        {
                                                            durum = "Geçti";
                                                        }
                                                        else
                                                        {
                                                            durum = "Kaldı";
                                                        }
                                                        string harfnotu = harfnotual(not); 
                                                        Console.WriteLine("{0} dersi not ortalamanız: {1} harf notunuz: {2} durumunuz: {3}", dersadi, not, harfnotu, durum);
                                                        break;
                                                    }
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Girilen not 100'den büyük olamaz!");
                                                i--;
                                            }                                            
                                        }
                                        else
                                        {
                                            Console.WriteLine("Not ortalamanız 100'ü geçti!");
                                            i--;
                                        }

                                    }
                                    catch
                                    {
                                        Console.WriteLine("Lütfen sayı giriniz!");
                                        i--;
                                    }
                                }
                                Console.Write("Not hesaplamak için H, çıkış yapmak için E yazınız.");
                                secenek = Convert.ToChar(Console.ReadLine());
                                if (secenek == 'E' || secenek == 'e')
                                {
                                    Console.WriteLine("Programdan çıkılıyor..");
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            catch 
                            {
                                Console.WriteLine("Lütfen geçerli bir seçim yapınız. Tekrar denemek için bir tuşa basınız");
                                Console.ReadKey();
                            }
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz işlem!. Lütfen yapmak istediğiniz işlemi seçiniz: "); 
                    }

                }
				catch 
				{
                    Console.WriteLine("Lütfen geçerli bir seçim yapınız. Tekrar denemek için bir tuşa basınız");
                    Console.ReadKey();
                }
			}
		}			 
    }
}
