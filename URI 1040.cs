using System;

namespace URI_1040
{
    class URI1040
    {
        static void Main(string[] args)
        {
            double N1, N2, N3, N4, m, m2;
            string[] x = Console.ReadLine().Split(' ');
            N1 = Convert.ToDouble(x[0]);
            N2 = Convert.ToDouble(x[1]);
            N3 = Convert.ToDouble(x[2]);
            N4 = Convert.ToDouble(x[3]);

            m = Math.Round(((N1 * 2.0) + (N2 * 3.0) + (N3 * 4.0) + (N4 * 1.0)) / (2.0 + 3.0 + 4.0 + 1.0),1);
            //m = m / salve;
            if (m >= 7)
            {
                Console.WriteLine($"Media: {string.Format("{0:0.0}",m)}\nAluno aprovado.");
            }
            else if(m>=5 & m < 7)
            {
                Console.WriteLine($"Media: {m.ToString("F1")}\nAluno em exame.");
                m2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Nota do exame: {m2.ToString("F1")}");
                m2 = (m + m2) / 2;

                if (m2 >= 5)
                {
                    Console.WriteLine($"Aluno aprovado.\nMedia final: {m2.ToString("F1")}");
                }
                else
                {
                    Console.WriteLine($"Aluno reprovado.\nMedia final: {m2.ToString("F1")}");
                }
            }
            else 
            {
                Console.WriteLine($"Media: {m.ToString("F1")}\nAluno reprovado.");
            }
        }
    }
}
