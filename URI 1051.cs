using System;

namespace URI_1051
{
    class Program
    {
        const double imp = 0.08;
        const double imp2 = 0.18;
        const double imp3 = 0.28;
        static void Main(string[] args)
        {
            double value = Convert.ToDouble(Console.ReadLine());
            double val = value;
            double res = value;

            if (value <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else if (value>2000 & value<=3000)
            {
                value = value - 2000;
                res = value * imp;
                Console.WriteLine("R$ " + res.ToString("F2"));
            }
            else if (value>3000 & value<=4500)
            {
                value = 1000;
                val = val - 3000;
                res = (value * imp) + (val * imp2);
                Console.WriteLine("R$ " + res.ToString("F2"));
            }
            else
            {
                value = 1000;
                val = 1500;
                res = res - 4500;
                res = (value * imp) + (val * imp2) + (res * imp3);
                Console.WriteLine("R$ " + res.ToString("F2"));
            }
        }
    }
}
