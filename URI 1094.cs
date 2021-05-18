using System;

namespace URI_1094
{
    class Program
    {
        const double por = 100.0;
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int quantia = 0, s=0, sapos=0, ratos=0, coelhos=0;
            char tipo = ' ';

            for (int i = 0; i<n; i++)
            {
                string[] a = Console.ReadLine().Split(' ');
                quantia = Convert.ToInt32(a[0]);
                tipo = Convert.ToChar(a[1]);

                if(tipo == 'C')
                {
                    coelhos += quantia;
                }
                else if(tipo == 'R')
                {
                    ratos += quantia;
                }
                else if (tipo == 'S')
                {
                    sapos += quantia;
                }
                s = s + quantia;
            }
            Console.WriteLine($"Total: {s} cobaias\nTotal de coelhos: {coelhos}\nTotal de ratos: {ratos}\nTotal de sapos: {sapos}\nPercentual de coelhos: {((coelhos*por)/s).ToString("F2")} %\nPercentual de ratos: {((ratos*por)/s).ToString("F2")} %\nPercentual de sapos: {((sapos*por)/s).ToString("F2")} %");
        }
    }
}
