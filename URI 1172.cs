using System;

namespace URI_BEGINNER
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            for (int i = 0; i < 10; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());

                if (x < 1)
                {
                    x = 1;
                }
                Console.WriteLine($"X[{i}] = {x}");
            }
        }
    }
}
