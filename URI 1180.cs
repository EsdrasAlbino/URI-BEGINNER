using System;

namespace URI_1180
{
    class URI1180
    {
        static void Main(string[] args)
        {

            int menor = 0, pos = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];
            string[] y = Console.ReadLine().Split(' ');
            menor = Convert.ToInt32(y[0]);

                for (int i = 0; i < n; i++)
                {
                x[i] = Convert.ToInt32(y[i]);
                    if (menor > x[i])
                    {
                        menor = x[i];
                        pos = i;
                    }
                }

                Console.WriteLine("Menor valor: " + menor);
                Console.WriteLine("Posicao: " + pos);

        }
    }
}
