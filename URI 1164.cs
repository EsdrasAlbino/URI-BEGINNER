using System;

namespace URI_1164
{
    class Program
    {
        static void Main(string[] args)
        {
            int test, n = Convert.ToInt32(Console.ReadLine());
            int condition;

            for (int i = 1; i<=n; i++)
            {
                test = 0;
                condition = 1;
                int x = Convert.ToInt32(Console.ReadLine());

                while (condition < x)
                {
                    if(x % condition == 0)
                    {
                        test += condition;
                    }
                    condition++;
                }
                if (test == x)
                {
                    Console.WriteLine($"{x} eh perfeito");
                }
                else
                {
                    Console.WriteLine($"{x} nao eh perfeito");
                }
            }
        }
    }
}
