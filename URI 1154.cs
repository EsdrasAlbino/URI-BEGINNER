using System;

namespace URI_1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int stop = 1, value, cont = 0;
            double s = 0;

            while (stop>=0)
            {
                value = Convert.ToInt32(Console.ReadLine());
                stop = value;
                if (stop >= 0)
                {      
                    s += value;
                    cont++;
                }
            }
            s = s / cont;
            Console.WriteLine(s.ToString("F2"));
        }
    }
}
