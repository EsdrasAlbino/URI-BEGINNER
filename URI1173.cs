using System;

namespace URI1173
{
    class URI1173
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];

            int v = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= 9; i++)
                {

                    n[i] = v;
                    Console.WriteLine("N[" + i + "] = " + n[i]);
                    v = v * 2;
                }
            
        }
    }
}
