using System;

namespace URI1014
{
    class URI1014
    {
        static void Main(string[] args)
        {
            int distancia = Convert.ToInt32(Console.ReadLine());
            double litros = Convert.ToDouble(Console.ReadLine());

            double media = distancia / litros;

            Console.WriteLine(media.ToString("F3") + " km/l");
        }
    }
}
