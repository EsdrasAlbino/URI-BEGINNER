using System;

namespace URI_1176
{
    class URI1176
    {
        static void Main(string[] args)
        {
            int x;
            int Count = Convert.ToInt32(Console.ReadLine());
            long[] V = new long[Count];

            for (int i = 0; i < Count; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());

                long A = 0;
                long B = 1;
                long C = 0;
                if (x >= 0 & x <= 60)
                {
                    for (int j = 0; j < x; j++)
                    {

                        A = B;
                        B = C;
                        C = A + B;
                    }
                    V[i] = C;
                    Console.WriteLine("Fib(" + x + ") = " + V[i]);

                }
            }
        }
    }
}
