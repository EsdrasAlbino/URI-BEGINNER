using System;

namespace URI_1115
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

                if (x==0 | y==0)
                {
                    break;
                }
                else if (x>0 & y>0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x<0 & y>0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x<0 & y<0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x>0 & y<0)
                {
                    Console.WriteLine("quarto");
                }
            }
        }
    }
}
