using System;

namespace URI_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod, qntd;

            double[] preco = { 4.0, 4.5, 5.0, 2.0, 1.5 };
            string[] v1 = Console.ReadLine().Split(' ');

            cod = Convert.ToInt32(v1[0]);
            qntd = Convert.ToInt32(v1[1]);

            Console.WriteLine("Total: R$ " + (preco[cod - 1] * qntd).ToString("F2"));
        }
    }
}
