using System;

namespace URI_1175
{
    class URI1175
    {
        static void Main(string[] args)
        {
            
            int[] n = new int[20];
            int y;

            for (int i = 0; i <= 19; i++)
            {
                y = Convert.ToInt32(Console.ReadLine());
                n[i] = y;  
            }
            y = 19;
            for (int i = 0; i <= 19; i++)
            {
                Console.WriteLine($"N[{i}] = {n[y]}");
                y--;
            }
        }
    }
}
