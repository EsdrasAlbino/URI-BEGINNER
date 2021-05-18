using System;

namespace URI_1146
{
    class Program
    {
        static void Main(string[] args)
        { // error time
            /*   for (int i = 1; i>0; i++)
               {
                   int a = Convert.ToInt32(Console.ReadLine());
                   if (a == 0) break;
                   for (int j = 1; j<=a; j++)
                   {
                       Console.Write(j);
                       if (j != a) Console.Write(" ");
                       else Console.WriteLine();
                   }   
               }

            int[] a = new int[10000];

            for (int i = 0; i>-1; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (a[i] == 0) break;
            }
            for (int i = 0; i>-1; i++)
            {
                if (a[i] == 0) break;
                for (int j = 1; j<=a[i]; j++)
                {
                    Console.Write(j);
                    if (j != a[i]) Console.Write(" ");
                    else Console.WriteLine();
                }
            }*/
 
        loop:
            int x = 1;
            string str = "";
            int n = Convert.ToInt32(Console.ReadLine());
            while (x <= n)
            {
                if (x == n) str += x++;
                else str += x++ + " ";
            }
            if (n!=0)
            {
                Console.WriteLine(str);
                goto loop;
            }
        }
    }
}
