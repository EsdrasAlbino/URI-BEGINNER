using System;

namespace URI_1036
{
    class URI1036
    {
        static void Main(string[] args)
        {
            double A, B, C, del, x1, x2;
            string[] value = Console.ReadLine().Split(' ');

            A = Convert.ToDouble(value[0]);
            B = Convert.ToDouble(value[1]);
            C = Convert.ToDouble(value[2]);

            del = Math.Pow(B, 2) - (4 * A * C);

            if (del > 0 & A != 0)
            {

                x1 = (-B + Math.Sqrt(del)) / (2 * A);
                x2 = (-B - Math.Sqrt(del)) / (2 * A);

                Console.WriteLine("R1 = " + x1.ToString("F5"));
                Console.WriteLine("R2 = " + x2.ToString("F5"));
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }
            
        }
    } 
}

