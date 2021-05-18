using System;

namespace URI_1155
{
    class Program
    {
        static void Main(string[] args)
        {
            double s=0, v = 1;
            
            for (double i = 1.0; i <= 100.0; i++)
            {
                v = 1;
                v /= i;
                s += v;
            }
            Console.WriteLine(s.ToString("F2"));
        }
    }
}
