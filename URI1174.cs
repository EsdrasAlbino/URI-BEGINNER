using System;

namespace URI_1074
{
    class URI1174
    {
        static void Main(string[] args)
        {
            double[] a = new double[100]; 
            double v;

            for (int i = 0; i <= 99; i++)
            {
                v = Convert.ToDouble(Console.ReadLine());
                a[i] = v;
                if (v <= 10)
                Console.WriteLine($"A[{i}] = {a[i].ToString("F1")}");
            }
        }
    }
}
