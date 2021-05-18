using System;

namespace Uri_1011
{
    class URI1011
    {
        static void Main(string[] args)
        {

            double pi = 3.14159;
            double R = Double.Parse(Console.ReadLine());

            double VOLUME = (4 / 3.0) * pi * Math.Pow(R, 3);

            Console.WriteLine("VOLUME = " + VOLUME.ToString("F3"));

        }
    }
}
