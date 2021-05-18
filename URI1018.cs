using System;

namespace UIR_1018
{
    class URI1018
    {
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());

            int x = n / 100;
            int y = (n - (x*100)) / 50;
            int z = (n - ((y * 50) + (x * 100))) / 20;
            int a = (n - ((z * 20) + (y * 50) + (x * 100))) / 10;
            int b = (n - ((a*10)+ (z * 20) + (y * 50) + (x * 100)))/ 5;
            int c = (n - ((b * 5) + (a * 10) + (z * 20) + (y * 50) + (x * 100)))/2;
            int d = (n - ((c * 2) + (b * 5) + (a * 10) + (z * 20) + (y * 50) + (x * 100))) / 1;

            Console.WriteLine(n);
            Console.WriteLine(x + " nota(s) de R$ 100,00");
            Console.WriteLine(y + " nota(s) de R$ 50,00");
            Console.WriteLine(z + " nota(s) de R$ 20,00");
            Console.WriteLine(a + " nota(s) de R$ 10,00");
            Console.WriteLine(b + " nota(s) de R$ 5,00");
            Console.WriteLine(c + " nota(s) de R$ 2,00");
            Console.WriteLine(d + " nota(s) de R$ 1,00");
            
        }
    }
}
