using System;

namespace URI_1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, x, y, n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] value = Console.ReadLine().Split(' ');
                x = Convert.ToInt32(value[0]);
                y = Convert.ToInt32(value[1]);

                while (y < x || y > x)
                {
                    if (y > x)
                    {
                        x++;
                        if (x % 2 == 1)
                        {
                            if (x != y)
                            {
                                cont += x;
                            }
                        }
                    }
                    else if (x > y)
                    {
                        y++;
                        if (y % 2 == 1)
                        {
                            if (y != x)
                            {
                                cont += y;
                            }
                        }
                    }
                }
                Console.WriteLine(cont);
                cont = 0;

            }
        }
    }
}
