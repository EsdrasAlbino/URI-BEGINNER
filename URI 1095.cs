using System;

namespace URI_1095
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 60;

            for(int p = 0; j>=0; p++)
            {
                Console.WriteLine($"I={i} J={j}");
                i += 3;
                j -= 5;
            }
        }
    }
}
