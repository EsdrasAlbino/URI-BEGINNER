using System;

namespace URI_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');
            int b, c, i=0;
            b = Convert.ToInt32(a[0]);
            c = Convert.ToInt32(a[1]);

            if (b < c)
            {
                i = c - b;
                Console.WriteLine($"O JOGO DUROU {i} HORA(S)");
            }
            else if (b > c)
            {
                b = 24 - b;
                i = b + c;
                Console.WriteLine($"O JOGO DUROU {i} HORA(S)");
            }
            else
            {
                i = 24;
                Console.WriteLine($"O JOGO DUROU {i} HORA(S)");
            }
        }
    }
}
