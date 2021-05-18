using System;

namespace URI1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;
            double g1, g2;

            string[] v1 = Console.ReadLine().Split(' ');
            string[] v2 = Console.ReadLine().Split(' ');

            x1 = Convert.ToDouble(v1[0]);
            y1 = Convert.ToDouble(v1[1]);
            x2 = Convert.ToDouble(v2[0]);
            y2 = Convert.ToDouble(v2[1]);

            g1 = x2 - x1;
            g2 = y2 - y1;

            double distancia = Math.Sqrt(Math.Pow(g1, 2) + Math.Pow(g2, 2));

            Console.WriteLine(distancia.ToString("F4"));

        }
    }
}
