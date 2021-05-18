using System;

namespace URI_1156
{
    class Program
    {
        static void Main(string[] args)
        {
                   double deno = 1,soma = 0; 

                      for (int i = 1; i<=39; i+=2)
                       {
                           soma += i/deno;
                           deno *= 2;
                         
                       }
                       Console.WriteLine(soma.ToString("F2"));

        }
    }
}
