using System;

namespace URI_1117
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k=0;
            float x;
            float res=0;
            for (i = 0; i>-1; i++)
            {
                x = Convert.ToSingle(Console.ReadLine());
                if (x<0 || x>10)
                {
                    Console.WriteLine("nota invalida");
                }
                else 
                {
                    k++;
                    res += x;
                    if(k==2) break;

                }
            }
            Console.WriteLine("media = " + (res/2.0).ToString("F2"));
            
        }
    }
}
