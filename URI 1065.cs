using System;

namespace URI_1065
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, cont = 0;
            for (int i = 0; i <= 4; i++)
            {
                b = Convert.ToDouble(Console.ReadLine());
                if (b % 2 == 0)
                {
                    cont++;
                }
            }
            Console.WriteLine(cont + " valores pares");
        }
    }
}
