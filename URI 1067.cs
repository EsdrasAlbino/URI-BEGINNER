using System;

namespace URI_1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i =0; i<=a; i++)
            {
                if (i % 2 != 0) Console.WriteLine(i);
            }
        }
    }
}
