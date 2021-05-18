using System;

namespace URI_1050
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int[] DDD = { 61, 71, 11, 21, 32, 19, 27, 31 };
            string[] capital = { "Brasilia", "Salvador", "Sao Paulo", "Rio de Janeiro", "Juiz de Fora", "Campinas", "Vitoria", "Belo Horizonte"};
            int b = 0;

            for (int i = 0; i<8; i++)
            {
                if (DDD[i] == a)
                {
                    Console.WriteLine(capital[i]);
                    break;
                }
                else if (DDD[i] != a)
                {
                    b++;
                }
            }
            if (b == 8)
            {
                Console.WriteLine("DDD nao cadastrado");
            }

            /*
             OR (Consumes more memory)
            if (a == 61)
            {
                Console.WriteLine("Brasilia");
            }
            else if (a == 71)
            {
                Console.WriteLine("Salvador");
            }
            else if (a == 11)
            {
                Console.WriteLine("Sao Paulo");
            }
            else if (a == 21)
            {
                Console.WriteLine("Rio de Janeiro");
            }
            else if (a == 32)
            {
                Console.WriteLine("Juiz de Fora");
            }
            else if (a == 19)
            {
                Console.WriteLine("Campinas");
            }
            else if (a == 27)
            {
                Console.WriteLine("Vitoria");
            }
            else if (a == 31)
            {
                Console.WriteLine("Belo Horizonte");
            }
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }
           */
        }
    }
}
