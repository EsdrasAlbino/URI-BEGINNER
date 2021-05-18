using System;

namespace URI_1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int  n = Convert.ToInt32(Console.ReadLine());
            float res;
            for(int i = 0; i<n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                float x = Convert.ToSingle(values[0]);
                float y = Convert.ToSingle(values[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    res = x / y;
                    Console.WriteLine(res.ToString("F1"));
                }
            }
        }
    }
}
