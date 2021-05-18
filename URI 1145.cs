using System;

namespace URI_1145
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] value = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(value[0]);
            int y = Convert.ToInt32(value[1]);

            for (int i = 1; i<=y; i++)
            {
                    Console.Write(i);
                if(i%x!=0) Console.Write(" ");
                else Console.WriteLine();
            }
        }
    }
}
