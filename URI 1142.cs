using System;

namespace URI_1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int j=1,n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<=n; i++)
            {
                //int[] a = new int[n * 7];

                for (j *= 1; j <= 4*i; j++)
                {
                    if (j % 4 == 0)
                    {
                        //j++;
                    }
                    else 
                    {
                        Console.Write(j);
                        Console.Write(" ");
                    }
                            
                }
                Console.WriteLine("PUM");
                
            }
        }
    }
}
