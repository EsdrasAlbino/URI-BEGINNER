using System;

namespace URI_1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double[,] value = new double[,] { { 0,25 } , { 25,50 } , { 50,75 } , { 75,100 } };
            
            if (x>=0 & x<=25.00)
            {
                Console.WriteLine($"Intervalo [{value[0,0]},{value[0,1]}]");
            }
            else if (x>25 & x<=50)
            {
                Console.WriteLine($"Intervalo ({value[1, 0]},{value[1, 1]}]");
            }
            else if (x>50 & x<=75)
            {
                Console.WriteLine($"Intervalo ({value[2, 0]},{value[2, 1]}]");
            }
            else if (x>75 & x<=100)
            {
                Console.WriteLine($"Intervalo ({value[3, 0]},{value[3, 1]}]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
