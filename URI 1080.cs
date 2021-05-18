using System;

namespace URI_1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 0, b = 0, i;
            
            for (i = 0; i < 100; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());

                if (p < a)
                {
                    p = a; 
                    b = i + 1;
                }
            }
            Console.WriteLine(p+"\n"+b);
        }
    }
}
