using System;

namespace URI_1118
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k = 0;
            float x;
            float res = 0;
            for (i = 0; i > -1; i++)
            {
            volta:
                x = Convert.ToSingle(Console.ReadLine());
                if (x < 0 || x > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    k++;
                    res += x;
                    if (k == 2)
                    {
                        Console.WriteLine("media = " + (res / 2.0).ToString("F2"));
                    again:
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        int o = Convert.ToInt32(Console.ReadLine());
                        if (o == 1 | o>2)
                        {
                            if (o == 1) 
                            {
                                k = 0;
                                res = 0;
                                goto volta;
                            }

                            goto again;
                        }
                        else 
                        {
                            break;
                        }
                        
                    }
                }
            }
            
        }
    }
}
