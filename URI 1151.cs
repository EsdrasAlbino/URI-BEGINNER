using System;

namespace URI_1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            long[] V = new long[44];
            long A , B = 1, C = 0;

            for (int i = 0; i < n; i++)
            {
                if (i > 0)
                {
                    A = B;
                    B = C;
                    C = A + B;
                    V[i] = C;
                }

                if (i == 0) Console.Write(0 + " ");
                else if(i != n - 1) Console.Write(V[i] + " ");
                else Console.WriteLine(V[i]);
            }      
        }
    }
}
