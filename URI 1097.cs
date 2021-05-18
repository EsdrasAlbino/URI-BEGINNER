using System;

namespace URI_1097
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 7, c = 0;

            for (int l = 0; i <= 9; l++)
            {
                Console.WriteLine($"I={i} J={j}");
                j--;
                if (j == 4+c)
                {
                    j += 5;
                    i += 2;
                    c += 2;
                }
            }
        }
    }
}
