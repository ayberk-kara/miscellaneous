using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Memory_Card_Game
{
    internal class Program
    {

        /*
        
        static void printtable()
        {
            string[] d3 = new string[16] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16" };
            for (int i = 0; i < 16; i++)
            {
                Console.Write("| {0} ", d3[i]);
                if (i == 0 || i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == 6 || i == 7 || i == 8)
                {
                    Console.Write(" ");
                }
                if (i == 8 || i == 9 || i == 10 || i == 11)
                {
                    Console.Write("");
                }
                if (i == 15 || i == 11 || i == 7 || i == 3)
                {
                    Console.Write("|");
                }
                if (i == 3 || i == 7 || i == 11 || i == 15)
                {
                    Console.Write("\n");
                }
            }

            Console.ReadKey();

        }
        */


        static void Main(string[] args)
        {
            string[] d3 = new string[16] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16" };
            for (int i = 0; i < 16; i++)
            {
                Console.Write("| {0} ", d3[i]);
                if (i == 0 || i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == 6 || i == 7 || i == 8)
                {
                    Console.Write(" ");
                }
                if (i == 8 || i == 9 || i == 10 || i == 11)
                {
                    Console.Write("");
                }
                if (i == 15 || i == 11 || i == 7 || i == 3)
                {
                    Console.Write("|");
                }
                if (i == 3 || i == 7 || i == 11 || i == 15)
                {
                    Console.Write("\n");
                }
            }

            string[] d1 = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16" };
            string[] d2 = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "A", "B", "C", "D", "E", "F","G", "H" };
            string[] d4 = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"};
            d1 = d1.Except(new string[] { "16" }).ToArray();
         
            for (int i = 0; i < d2.Length; i++)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, d1.Length);    
                int a = Convert.ToInt16(d1[index]);    
                d4[a] = d2[i];
                d1 = d1.Except(new string[] { a.ToString() }).ToArray();
                  
            }
            string[] d7 = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
            string[] d8 = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
            string[] d9 = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
            Array.Copy(d3, 0, d7, 0, 16);
            Array.Copy(d4, 0, d8, 0, 16);

            for (int j = 0; j < d8.Length; j++)
            {
                Console.WriteLine("d3 elemanları:");
                Console.Write(d3[j]);
            }



            bool oyundevamediyor = true;
            bool validkart1 = false, validkart2 = false;
            int kart1=0, kart2=0, adimsayisi=0;
            while (oyundevamediyor)
            {
                while(validkart1==false || validkart2 ==false)
                {
                    Console.Write("Lütfen 1. kartı seçiniz: ");
                    kart1 = Convert.ToInt32(Console.ReadLine());
                    
                    if (kart1<17 && kart1 > 0)
                    {
                        validkart1 = true;
                        while (validkart2 == false)
                        {
                            Console.Write("Lütfen 2. kartı seçiniz: ");
                            kart2 = Convert.ToInt32(Console.ReadLine());
                            if (kart2 < 17 && kart1 > 0)
                            {
                                validkart2 = true;
                                if (false)//(d3.Count(str => str.Contains(d9[kart1-1])) > 1 || d3.Count(str => str.Contains(d9[kart2-1])) > 1)             
                                {
                                    Console.WriteLine("Açık olan bir kart seçtiniz!");
                                    validkart1 = false;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Lütfen geçerli bir kart giriniz.");
                                
                            }
                        }

                        
                    }
                    else
                    {
                        Console.WriteLine("Lütfen geçerli bir kart giriniz ");
                       
                    }

                }
                d3[kart1 - 1] = d4[kart1-1];
                d3[kart2 - 1] = d4[kart2 - 1];

                Console.WriteLine("Seçiminiz:");
                for (int i = 0; i < 16; i++)
                {
                    Console.Write("| {0} ", d3[i]);
                    if (i == 0 || i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == 6 || i == 7 || i == 8)
                    {
                        Console.Write(" ");
                    }
                    if (i == 8 || i == 9 || i == 10 || i == 11)
                    {
                        Console.Write("");
                    }
                    if (i == 15 || i == 11 || i == 7 || i == 3)
                    {
                        Console.Write("|");
                    }
                    if (i == 3 || i == 7 || i == 11 || i == 15)
                    {
                        Console.Write("\n");
                    }
                }

                Console.ReadKey();
                if (d4[kart1 - 1]== d4[kart2 - 1])
                {
                    Array.Copy(d3, 0, d7, 0, 16);
                    validkart1 = false;
                    validkart2 = false;
                    adimsayisi++;
                }
                else
                {
                    Array.Copy(d7, 0, d3, 0, 16);
                    validkart1 = false;
                    validkart2 = false;
                    adimsayisi++;
                }
                


                if (d8[0] == d3[0] && d8[1] == d3[1] && d8[2] == d3[2] && d8[3] == d3[3] && d8[4] == d3[4] && d8[5] == d3[5] && d8[6] == d3[6] && d8[7] == d3[7] && d8[8] == d3[8] && d8[9] == d3[9])
                {
                    Console.WriteLine("Oyun bitti!");
                    Console.WriteLine("Toplam adım sayısı : {0}", adimsayisi);
                    break;
                }

            }

            Console.ReadKey();

        }
    }
}