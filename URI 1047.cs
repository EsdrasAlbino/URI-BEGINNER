using System;

namespace URI_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');
            int b, c, bm, cm, i = 0, p = 0;
            b = Convert.ToInt32(a[0]);
            bm = Convert.ToInt32(a[1]);
            c = Convert.ToInt32(a[2]);
            cm = Convert.ToInt32(a[3]);

            if (b <= c & bm < cm)
            {
                i = c - b;
                p = cm - bm;
                Console.WriteLine($"O JOGO DUROU {i} HORA(S) E {p} MINUTO(S)");
            }
            else if (b <= c & bm > cm)
            {
                i = c - b;
                bm = 60 - bm;
                p = bm + cm;
                --i;
                if (b == c) i = 23;

                Console.WriteLine($"O JOGO DUROU {i} HORA(S) E {p} MINUTO(S)");
            }
            else if (b >= c & bm < cm)
            {
                b = 24 - b;
                i = b + c;
                p = cm - bm;
                Console.WriteLine($"O JOGO DUROU {i} HORA(S) E {p} MINUTO(S)");
            }
            else if (b >= c & bm > cm)
            {
                b = 24 - b;
                i = b + c;
                bm = 60 - bm;
                p = bm + cm;
                --i;
                Console.WriteLine($"O JOGO DUROU {i} HORA(S) E {p} MINUTO(S)");
            }
            else
            {
                i = 24;
                p = 0;
                Console.WriteLine($"O JOGO DUROU {i} HORA(S) E {p} MINUTO(S)");
            }
        }
    }
}
