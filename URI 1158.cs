using System;

namespace URI_1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<=n; i++)
            {
                int x, y = 0, s = 0, cont = 1;
                string[] value = Console.ReadLine().Split(' ');
                x = Convert.ToInt32(value[0]);
                y = Convert.ToInt32(value[1]);

                for (int j = x; cont <= y; j++) 
                {
                    if (j % 2 != 0)
                    {
                        cont++;
                        s += j;
                    }
                }
                Console.WriteLine(s);
            }
        }
    }
}
