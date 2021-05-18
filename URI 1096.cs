using System;

namespace URI_1096
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 7;

            for(int l =0; i<=9; l++)
            {
                Console.WriteLine($"I={i} J={j}");
                j--;
                if (j == 4)
                {
                    j += 3;
                    i += 2;
                }
            }
        }
    }
}
