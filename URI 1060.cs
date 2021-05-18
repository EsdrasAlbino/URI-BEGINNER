using System;

namespace URI_1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[5];
            double b,cont = 0;
            for (int i=0; i<=5; i++)
            {
                b = Convert.ToDouble(Console.ReadLine());
                //a[i] = b;
                if (b > 0)
                {
                    cont++;
                }
            }

            Console.WriteLine(cont+" valores positivos");
        }
    }
}
