using System;

namespace URI_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] d = Console.ReadLine().Split(' ');
            float a, b, c;
            a = Convert.ToSingle(d[0]);
            b = Convert.ToSingle(d[1]);
            c = Convert.ToSingle(d[2]);
            float a2 = a;

            if(a<b & a<c | a<b & a>=c | a>=b & a<c)
            {
                if(a < b & a < c)
                {
                    if (b > c)
                    {
                        a = b;
                        b = a2;
                    }
                    else
                    {
                        a = c;
                        c = a2;
                    }
                }
                else if(a < b & a >= c)
                {
                    a = b;
                    b = a2;
                }
                else
                {
                    a = c;
                    c = a2;
                }
            }
            //Console.WriteLine($"{a}{b}{c}");

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("TRIANGULO RETANGULO");

            }
            else if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
                if (a == b & b == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if(a==b & a!=c | a==c & a!=b | b == c & a != b)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
            else if (Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
                if (a == b & b == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if(a == b & a != c | a == c & a != b | b == c & a != b)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }

        }
    }
}
