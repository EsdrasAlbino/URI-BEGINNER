using System;

namespace URI_1114
{
    class Program
    {
        static void Main(string[] args)
        {
            const int key = 2002;
            
            for (int i = 1; i>0; i++)
            {
                int value = Convert.ToInt32(Console.ReadLine());

                if (value == key)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }
            }
        }
    }
}
