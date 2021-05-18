using System;

namespace URI_1144
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double cal, call;
            for (int i = 1; i <= n; i++)
            {
            
                cal = Math.Pow(i, 2);
                call = Math.Pow(i, 3);
                Console.Write(i);
                Console.Write(" ");
                Console.Write(cal);
                Console.Write(" ");
                Console.Write(call);
                Console.WriteLine("");
               
                    Console.Write(i);
                    Console.Write(" ");
                    Console.Write(cal+=1);
                    Console.Write(" ");
                    Console.Write(call+=1);
                    Console.WriteLine("");  
            }
            
        }
    }
}
