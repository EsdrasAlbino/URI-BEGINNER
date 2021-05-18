using System;

namespace URI_1153
{
    class URI1153
    {
        static void Main(string[] args)
        {
            int n, fatorial = 1;
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = n; i >= 1; i--)
            {
                fatorial = fatorial * i;
            }
            Console.WriteLine(fatorial);
        }
    }
}
