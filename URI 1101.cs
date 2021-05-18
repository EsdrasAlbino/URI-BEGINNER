using System;

namespace URI_1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0, j;

            for(int i = 1; i > 0; i++)
            {
                string[] value = Console.ReadLine().Split(' ');

                int m = Convert.ToInt32(value[0]);
                int n = Convert.ToInt32(value[1]);
                int save = m;

                if (m<n)
                {
                    m = n;
                    n = save;
                }
                if(m<=0 | n <= 0)
                {
                    break;
                }

                for (j = n; j<=m; j++)
                {
                    Console.Write(j+" ");
                    s += j;
                }
                Console.WriteLine("Sum=" + s);
                s = 0;
            }

        }
    }
}
