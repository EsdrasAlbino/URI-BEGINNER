using System;

namespace URI_1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<=n; i++)
            {
                Console.Write(i);
                Console.Write(" ");
                Console.Write(Math.Pow(i, 2));
                Console.Write(" ");
                Console.Write(Math.Pow(i, 3));
                Console.WriteLine("");
            }
        }
    }
}
