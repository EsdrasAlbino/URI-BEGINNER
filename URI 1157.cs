using System;

namespace URI_1157
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<=n; i++)
            {
                if (n % i == 0) Console.WriteLine(i);
            }
        }
    }
}
