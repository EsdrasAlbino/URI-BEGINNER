using System;

namespace URI_1042
{
    class URI1042
    {
        static void Main(string[] args)
        {
            string[] value = Console.ReadLine().Split(' ');
            int a, b, c;
            a = Convert.ToInt32(value[0]);
            b = Convert.ToInt32(value[1]);
            c = Convert.ToInt32(value[2]);
            int a2 = a;
            int b2 = b;
            int c2 = c;

            if (a2 < b2 & a2 < c2)
            {
                a = a2;
                if (b2 < c2)
                {
                 b = b2; c = c2;
                }
                else 
                {
                 b = c2; c = b2;
                }
            }
            else if (b2 < a2 & b2 < c2)
            {
                a = b2;
                if(a2 < c2)
                {
                    b = a2; c = c2;
                }
                else
                {
                    b = c2; c = a2;
                }
            }
            else
            {
                a = c2;
                if (a2 < b2)
                {
                    b = a2; c = b2;
                }
                else
                {
                    b = b2; c = a2;
                }
            }

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine("");
            Console.WriteLine(a2);
            Console.WriteLine(b2);
            Console.WriteLine(c2);

        }
    }
}
