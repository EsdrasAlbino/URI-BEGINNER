using System;

namespace URI_1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, alc=0, gas=0, die=0;
        loop:
            input = Convert.ToInt32(Console.ReadLine());

            if (input >4 || input <4)
            {
                if(input == 1) alc++;
                else if (input == 2) gas++;
                else if (input == 3) die++;

                goto loop;
            }

            Console.WriteLine("MUITO OBRIGADO\nAlcool: {0}\nGasolina: {1}\nDiesel: {2}", alc, gas, die);
        }
    }
}
