using System;

namespace URI_1165
{
    class URI1165
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            ulong x, y=0;

            for (int i = 0; i < n; i++)
            {
                x = Convert.ToUInt64(Console.ReadLine());

                for (ulong k = 1; k <= x; k++)
                { 
                    if (x % k == 0)
                    {
                        y++;
                    }
                }
                if (y == 2)
                {
                    Console.WriteLine(x + " eh primo");
                }
                else
                {
                    Console.WriteLine(x + " nao eh primo");
                }
                y = 0;
            }
        }
    }
}
