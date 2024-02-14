using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int satir, c = 1, b, i, j;


            Console.Write("Satır sayısını giriniz: ");
            satir = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < satir; i++)
            {
                for (b = 1; b <= satir - i; b++)
                    Console.Write("  ");
                for (j = 0; j <= i; j++)
                {
                    int ieksij = i-j;
                    int s1 = i;
                    int s2 = j;
                    int s3 = i - j;
                    if (j == 0 || i == 0||i==j)
                        c = 1;

                    
                    else
                    {
                        
                        for (int k = i-1; 0 < k; k--)
                        {
                            s1 *= k;


                        }
                        for (int q = j-1; 0 < q; q--)
                        {
                            s2 *= q;
                            

                        }
                        for (int p = i-j-1; 0 < p; p--)
                        {
                            
                            s3 *= p;
                            

                        }
                        if (s3 == 0)
                        {
                            s3 = 1;
                            
                        }
                        c = s1 / (s2*s3);
                    }
                        
                    Console.Write("{0}   ", c);
                }
                Console.Write("\n");

            }

            Console.ReadKey();


        }
    }
}