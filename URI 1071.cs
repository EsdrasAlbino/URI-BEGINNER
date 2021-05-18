using System;

namespace URI_1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int c, b = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            c = a;
            if(a>b)
            {
                
                a = b;
                b = c;
            }

            for (int i=a+1; i<b; i++)
            {
                if (i % 2 !=0) s = s + i;
            }
            Console.WriteLine(s);
        }
    }
}
