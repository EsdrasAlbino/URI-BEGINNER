using System;

namespace URI_1052
{
    class Program
    {
        static void Main(string[] args)
        {
            int mo = Convert.ToInt32(Console.ReadLine());
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            string[] moth = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

            for (int i = 0; i<12; i++)
            {
                if (a[i] == mo)
                {
                    Console.WriteLine(moth[i]);
                }
            } 
        }
    }
}
