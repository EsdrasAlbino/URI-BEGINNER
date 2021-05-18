using System;

namespace URI_1044
{
    class URI1044
    {
        static void Main(string[] args)
        {
            string[] value = Console.ReadLine().Split();
            int a, b;
            a = Convert.ToInt32(value[0]);
            b = Convert.ToInt32(value[1]);

            if(a%b == 0 || b%a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
