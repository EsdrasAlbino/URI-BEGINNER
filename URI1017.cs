using System;

namespace URI_1017
{
    class URI1017
    {
        static void Main(string[] args)
        {
            int vel, hor; 
            double cons;

            hor = Convert.ToInt32(Console.ReadLine());
            vel = Convert.ToInt32(Console.ReadLine());

            cons = (vel * hor) / 12.0;

            Console.WriteLine(cons.ToString("F3"));
        }
    }
}
