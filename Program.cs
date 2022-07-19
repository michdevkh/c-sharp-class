using System;

namespace DoubleDivision
{
    internal class Program
    {
        static void MainX(string[] args)
        {
            int n,m=1;
            double t=0;
            String str = "";
            Console.Write("Enter n=");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n;i++)
            {
                str += $"{m}/{m+1}";
                if (i != n)
                {
                    str += " + ";
                }
                t +=(double) m / (m + 1);
                m += 2;
            }
            Console.WriteLine($"{str} = {t:#0.##}");

            Console.ReadKey();
        }
    }
}
