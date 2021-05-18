using System;

namespace URI_1061
{
    class Program
    {
 

        static void Main(string[] args)
        {
            int dayF, hourF, minF, secF, dayN, hourN, minN, secN;

            string[] h = Console.ReadLine().Split(' ');

            dayF = Convert.ToInt32(h[1]);
            string[] h1 = Console.ReadLine().Split(' ');
            hourF = Convert.ToInt32(h1[0]);
            minF = Convert.ToInt32(h1[2]);
            secF = Convert.ToInt32(h1[4]);

            string[] h2 = Console.ReadLine().Split(' ');
         
            dayN = Convert.ToInt32(h2[1]);
            string[] h3 = Console.ReadLine().Split(' ');
            hourN = Convert.ToInt32(h3[0]);
            minN = Convert.ToInt32(h3[2]);
            secN = Convert.ToInt32(h3[4]);

            if (secF <= secN)
            {
                secN = secN - secF;
            }
            else if (secF > secN)
            {
                secF = 60 - secF;
                secN = secF + secN;
                minF += 1;
            }

            if (minF <= minN)
            {
                minN = minN - minF;
            }
            else if (minF > minN)
            {
                minF = 60 - minF;
                minN = minF + minN;
                hourF += 1;
            }

            if (hourF <= hourN)
            {
                hourN = hourN - hourF;
            }
            else if (hourF > hourN)
            {
                hourF = 24 - hourF;
                hourN = hourF + hourN;
                dayF += 1;
            }
            dayN = dayN - dayF;

            Console.WriteLine($"{dayN} dia(s)\n{hourN} hora(s)\n{minN} minuto(s)\n{secN} segundo(s)");
           
        }



    }
}

