using System;

namespace URI1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            double tempo;
            distancia = Convert.ToInt32(Console.ReadLine());

            tempo = distancia * 2;

            Console.WriteLine(tempo+" minutos");

        }
    }
}
