using System;

namespace URI_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int o = 0, p = 0, q = 0;

          p = n / 365;
          o = (n - (365 * p)) / 30;
          q = n - ((30 * o) + (365 * p));
            Console.WriteLine($"{p} ano(s)\n{o} mes(es)\n{q} dia(s)");
        }
    }
}
