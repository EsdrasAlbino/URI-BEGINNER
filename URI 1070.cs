using System;

namespace URI_1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= a+11; i++)
            {
                if (i % 2 != 0) Console.WriteLine(i);
            }
        }
    }
}
