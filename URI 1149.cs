using System;

namespace URI_1149
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n, i, s=0;
            string[] va = Console.ReadLine().Split(' ');
            a = Convert.ToInt32(va[0]);
            n = Convert.ToInt32(va[1]);
            i = 1;

            while (n <= 0)
            {
                i++;
                n = Convert.ToInt32(va[i]);
            }
            i = 0;
            for (int j = 0; j<n; j++)
            {
                s += a + j;
            }
            Console.WriteLine(s);
        }
    }
}
