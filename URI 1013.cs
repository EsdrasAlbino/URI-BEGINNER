using System;

namespace URI1013
{
    class URI1013
    {
        static void Main(string[] args)
        {
            int A, B, S, m, maiorAB;
            string a1 = Console.ReadLine();

            string[] v1 = a1.Split(' ');
            A = Convert.ToInt32(v1[0]);
            B = Convert.ToInt32(v1[1]);
            S = Convert.ToInt32(v1[2]);

            m = (A + B + Math.Abs(A - B)) / 2;
            maiorAB = (m + S + Math.Abs(m - S)) / 2;

            Console.WriteLine(maiorAB +" eh o maior");

        }
    }
}
