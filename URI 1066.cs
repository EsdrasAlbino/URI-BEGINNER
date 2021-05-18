using System;

namespace URI_1066
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, cont = 0, conti = 0, contp = 0, contn = 0;
            for (int i = 0; i <= 4; i++)
            {
                b = Convert.ToDouble(Console.ReadLine());

                if (b % 2 == 0)
                {
                    cont++;
                }
                else
                {
                    conti++;
                }

                if (b > 0) contp++;
                if (b < 0) contn++;
            }
            Console.WriteLine($"{cont} valor(es) par(es)\n{conti} valor(es) impar(es)\n{contp} valor(es) positivo(s)\n{contn} valor(es) negativo(s)");
        }
    }
}
