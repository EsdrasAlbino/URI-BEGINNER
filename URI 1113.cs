using System;

namespace URI_1113
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i>0; i++)
            {
                string[] value = Console.ReadLine().Split(' ');
                int x = Convert.ToInt32(value[0]);
                int y = Convert.ToInt32(value[1]);

                if (x>y)
                {
                    Console.WriteLine("Decrescente");
                }
                else if (x<y) 
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    break;
                }
            }
        }
    }
}
