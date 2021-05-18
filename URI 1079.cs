using System;

namespace URI_1079
{
    class Program
    {
        const int p1 = 2;
        const int p2 = 3;
        const int p3 = 5;
        const int sP = p1 + p2 + p3;
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double x, y, z, s;

            for (int i =0; i<n; i++)
            {
                string[] a = Console.ReadLine().Split();
                x = Convert.ToDouble(a[0]);
                y = Convert.ToDouble(a[1]);
                z = Convert.ToDouble(a[2]);
                s = (x * p1) + (y * p2) + (z * p3);
                Console.WriteLine($"{(s/sP).ToString("F1")}");
            }
        }
    }
}
