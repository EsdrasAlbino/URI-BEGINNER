using System;

namespace URI_1012
{
    class URI1012
    {
        static void Main(string[] args)
        {
            double A, B, C;
            double trian, c, trap, q, r;
            double pi = 3.14159;
            string n1 = Console.ReadLine();

            string[] v1 = n1.Split(' ');
            A = Convert.ToDouble(v1[0]);
            B = Convert.ToDouble(v1[1]);
            C = Convert.ToDouble(v1[2]);

            trian = A * C / 2;
            c = pi * Math.Pow(C, 2);
            trap = (A + B) * C / 2;
            q = Math.Pow(B, 2);
            r = A * B;

            Console.WriteLine("TRIANGULO: " + trian.ToString("F3") + "\nCIRCULO: " + c.ToString("F3") + "\nTRAPEZIO: " + trap.ToString("F3") + "\nQUADRADO: " + q.ToString("F3") + "\nRETANGULO: " + r.ToString("F3") );
            Console.WriteLine("TRIANGULO: " + trian.ToString("F3"));
            Console.WriteLine("CIRCULO: " + c.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trap.ToString("F3"));
            Console.WriteLine("QUADRADO: " + q.ToString("F3"));
            Console.WriteLine("RETANGULO: " + r.ToString("F3"));
        }
    }
}
