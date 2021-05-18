using System;

namespace URI_1041_CSHARP
{
    class URI1041
    {
        static void Main(string[] args)
        {
            string[] cord = Console.ReadLine().Split(' '); 
            double x , y;

            x = Convert.ToDouble(cord[0]);
            y = Convert.ToDouble(cord[1]);


            if (x>0 & y>0)
            {
                Console.WriteLine("Q1");
            }
            else if (x<0 & y>0)
            {
                Console.WriteLine("Q2");
            }
            else if (x<0 & y<0)
            {
                Console.WriteLine("Q3");
            }
            else if(x>0 & y<0)
            {
                Console.WriteLine("Q4");
            }
            else if (y==0 & x<0||x>0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x==0 & y<0||y>0)
            {
                Console.WriteLine("Eixo Y");
            }
            else
            {
                Console.WriteLine("Origem");
            }
        }
    }
}
