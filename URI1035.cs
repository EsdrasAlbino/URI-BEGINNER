using System;

namespace URI_1035
{
    class URI1035
    {
        static void Main(string[] args)
        {
            string[] x = new string[3];
            x = Console.ReadLine().Split(' ');
            int A = Convert.ToInt32(x[0]);
            int B = Convert.ToInt32(x[1]);
            int C = Convert.ToInt32(x[2]);
            int D = Convert.ToInt32(x[3]);

            if(B>C & D>A & C+D>A+B & C>0 & D>0 & A%2==0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
