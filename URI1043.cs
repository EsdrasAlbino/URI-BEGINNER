using System;

namespace URI_1043
{
    class URI1043
    {
        static void Main(string[] args)
        {
            string[] value = Console.ReadLine().Split();
            double a, b, c, cal;
            a = Convert.ToDouble(value[0]);
            b = Convert.ToDouble(value[1]);
            c = Convert.ToDouble(value[2]);

            if(Math.Abs(b-c) < a & a < b+c & Math.Abs(a-c) < b & b < a+b & Math.Abs(a-b) < c & c < a + b)
            {
                cal = a + b + c;
                Console.WriteLine("Perimetro = "+cal.ToString("F1"));
            }
            else
            {
                cal = ((a+b)*c)/2.0;
                Console.WriteLine("Area = " + cal.ToString("F1"));
            }
                

        }
    }
}
