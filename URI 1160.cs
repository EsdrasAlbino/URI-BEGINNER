using System;
using System.Globalization;

namespace URI_1160
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

             for (int i = 1; i <= t; i++)
             {
                 double g1, g2, tx, tx2;
                 int pA, pB, anos = 0;
                 string[] value = Console.ReadLine().Split(' ');

                 pA = Convert.ToInt32(value[0]);
                 pB = Convert.ToInt32(value[1]);
                 g1 = Convert.ToDouble(value[2]);
                 g2 = Convert.ToDouble(value[3]);

                 while (pA <= pB)
                 {
                     tx = pA * (g1/100.0);
                     tx2 = pB * (g2/100.0);
                     anos++;
                     pA += (int)tx;
                     pB += (int)tx2;

                    Console.WriteLine("----TX " + tx);
                    Console.WriteLine("----TX2 " + tx2);
                }

                 Console.WriteLine("----" + pA);
                 Console.WriteLine("----" + pB);

                 if (anos > 100) Console.WriteLine("Mais de 1 seculo.");
                 else Console.WriteLine($"{anos} anos.");

                 while(anos >= 0)
                 {
                     anos--;
                 }

             }
        }
    }
}

