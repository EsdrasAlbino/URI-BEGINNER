using System;

namespace URI_1150
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, z, s=0, c=0;

            x = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());

            while (z<=x)
            {
                z = Convert.ToInt32(Console.ReadLine());
            }
            
            while (s<z)
            {
                s += x;
                x++;
                c++;

            }
            Console.WriteLine(c);

        }
    }
}
