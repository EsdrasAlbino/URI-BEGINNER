using System;

namespace URI_1019
{
    class URI1019
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int o = 0, p = 0, q = 0;

            if (n > 60)
            {
                p = n / (60 * 60);
                o = (n - (60*60*p))/ 60;
                q = n - ((60 * o) + (60 * 60 * p));
                Console.WriteLine($"{p}:{o}:{q}");
            }
            else
            {
                Console.WriteLine($"{p}:{o}:{n}");
            }
        }
    }
}
