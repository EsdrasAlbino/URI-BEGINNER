using System;

namespace URI_1098
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, j, k;
            for (i = 0; i <= 2; i += .2)
            {
                for (j = 1.0; j <= 3.0; j++)
                {
                    k = j + i;
                    if (i == 0.0 || i == 1.0)
                    {
                        Console.Write("I={0} ", i.ToString("0"));
                        Console.WriteLine("J={0}", k.ToString("0"));
                    }
                    else if (k == 3.0 || k == 4.0 || k == 5.0)
                    {
                        Console.Write("I={0} ", i.ToString("0"));
                        Console.WriteLine("J={0}", k.ToString("0"));
                    }
                    else
                    {
                        Console.Write("I={0} ", i.ToString("0.0"));
                        Console.WriteLine("J={0}", k.ToString("0.0"));
                    }


                }
            }
        }
    }
}

