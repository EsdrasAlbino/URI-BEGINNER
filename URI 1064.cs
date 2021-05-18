using System;

namespace URI_1064
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, cont = 0, s=0;
            for (int i = 0; i <= 5; i++)
            {
                b = Convert.ToDouble(Console.ReadLine());
                if (b > 0)
                {
                    cont++;
                    s = s + b;
                }
            }
            Console.WriteLine(cont + " valores positivos\n"+(s/cont).ToString("F1"));
        }
    }
}
