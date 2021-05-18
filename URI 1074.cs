using System;

namespace URI_1074_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i<n; i++ )
            {
                int a = Convert.ToInt32(Console.ReadLine());

                if (a % 2 == 0 & a > 0) Console.WriteLine("EVEN POSITIVE");
                else if (a % 2 != 0 & a > 0) Console.WriteLine("ODD POSITIVE");
                else if (a % 2 == 0 & a < 0) Console.WriteLine("EVEN NEGATIVE");
                else if (a % 2 != 0 & a < 0) Console.WriteLine("ODD NEGATIVE");
                else Console.WriteLine("NULL");
            }
        }
    }
}
