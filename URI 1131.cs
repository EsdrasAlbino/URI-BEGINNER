using System;

namespace URI_1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = 0,i = 0,k = 0, empate = 0;
        loop:
            k++;
            string[] value = Console.ReadLine().Split(' ');
            int inter = Convert.ToInt32(value[0]);
            int gremio = Convert.ToInt32(value[1]);

            if (inter>gremio)
            {
                i++;
            }
            else if (gremio>inter)
            {
                g++;
            }
            else
            {
                empate++;
            }
            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            char loop = Convert.ToChar(Console.ReadLine());

            if (loop == '1')
            {
                goto loop;
            }

            if (i>g) Console.WriteLine("{0} grenais\nInter:{1}\nGremio:{2}\nEmpates:{3}\nInter venceu mais", k, i, g, empate);
            else if (g>i) Console.WriteLine("{0} grenais\nInter:{1}\nGremio:{2}\nEmpates:{3}\nGremio venceu mais", k, i, g, empate);
            else Console.WriteLine("{0} grenais\nInter:{1}\nGremio:{2}\nEmpates:{3}\nNao houve vencedor", k, i, g, empate);

        }
    }
}
