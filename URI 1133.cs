using System;

namespace URI_1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, min, max;

            x = Convert.ToInt32(Console.ReadLine());        
            y = Convert.ToInt32(Console.ReadLine());

            min = Math.Min(x, y);
            max = Math.Max(x, y);

            for (int i = min+1; i < max; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
