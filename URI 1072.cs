using System;

namespace URI_1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 0, f = 0, n = Convert.ToInt32(Console.ReadLine()), b;
            
            for (int i=0; i<n; i++)
            {
                b = Convert.ToInt32(Console.ReadLine());

                if (b >= 10 & b <= 20)
                {
                    d++;
                }
                else
                {
                    f++;
                }
            }
            Console.WriteLine($"{d} in\n{f} out");
        }
    }
}
