using System;

namespace URI_1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int res = 0, y2 = 0, y = Convert.ToInt32(Console.ReadLine());
            y2 = x;

            if (y < x)
            {
                x = y;
                y = y2;
            }

            for (int i = x; i <= y; i++)
            {
                if (i % 13 != 0) res += i;
            }
            Console.WriteLine(res);
        }
    }
}
