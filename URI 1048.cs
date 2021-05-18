using System;

namespace URI_1048
{
    class Program
    {
        const float tx1 = 15f;
        const float tx2 = 12f;
        const float tx3 = 10f;
        const float tx4 = 7f;
        const float tx5 = 4f;
        static void Main(string[] args)
        {
            float value = Convert.ToSingle(Console.ReadLine());
            float res, newS;
            if (value >0 & value <=400)
            {
                res = (value * tx1)/100.0f;
                newS = value + res;
                Console.WriteLine($"Novo salario: {newS.ToString("F2")}\nReajuste ganho: {res.ToString("F2")}\nEm percentual: {tx1} %");
            }
            else if (value > 400 & value <= 800)
            {
                res = (value * tx2) / 100.0f;
                newS = value + res;
                Console.WriteLine($"Novo salario: {newS.ToString("F2")}\nReajuste ganho: {res.ToString("F2")}\nEm percentual: {tx2} %");
            }
            else if (value > 800 & value <= 1200)
            {
                res = (value * tx3) / 100.0f;
                newS = value + res;
                Console.WriteLine($"Novo salario: {newS.ToString("F2")}\nReajuste ganho: {res.ToString("F2")}\nEm percentual: {tx3} %");
            }
            else if (value > 1200 & value <=2000)
            {
                res = (value * tx4) / 100.0f;
                newS = value + res;
                Console.WriteLine($"Novo salario: {newS.ToString("F2")}\nReajuste ganho: {res.ToString("F2")}\nEm percentual: {tx4} %");
            }
            else
            {
                res = (value * tx5) / 100.0f;
                newS = value + res;
                Console.WriteLine($"Novo salario: {newS.ToString("F2")}\nReajuste ganho: {res.ToString("F2")}\nEm percentual: {tx5} %");
            }
        }
    }
}
