using System;

namespace URI_1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while(x!=0)
            {
                int soma = 0, cont = 1;
                x = Convert.ToInt32(Console.ReadLine());
                if (x != 0)
                {
                    for (int j = x; cont <= 5; j++)
                    {
                        if (j % 2 == 0)
                        {
                            cont++;
                            soma += j;
                        }
                    }
                    Console.WriteLine(soma);
                }
            }
        }
    }
}
