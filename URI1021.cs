using System;

namespace URI_1021
{
    class URI1021
    {
        static void Main(string[] args)
        {
            
            double n = Convert.ToDouble(Console.ReadLine());
            int[] cedulas = new int[] { 10000, 5000, 2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1 };
            int res, n2;
            n2 = Convert.ToInt32(n*100);
            
            for (int i = 0; i<12; i++)
            {
                res = n2 / cedulas[i];
                string i0 = "nota(s)";
                if (i == 0)
                {
                    Console.WriteLine("NOTAS:");
                }
                if (i == 6)
                {
                    Console.WriteLine("MOEDAS:");
                }
                if (i >= 6)
                {
                    i0 = "moeda(s)";
                }
                    Console.WriteLine(res +" "+ i0 + " de R$ " + (cedulas[i]/100.0).ToString(("#0.00")));
                n2 %= cedulas[i];
            }
        }
    }
}
