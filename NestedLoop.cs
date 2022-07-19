using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDivision
{
    internal class NestedLoop
    {
        static void MainN()
        {
            int n,counter=0,star;
            Console.Write("Enter n=");
            star = int.Parse(Console.ReadLine());
            /*for (int i = 1; i <= n; i++)
            {
                counter+=i;
                if (counter <= n)
                {
                    Console.WriteLine(string.Concat(Enumerable.Repeat("*", i)));
                }
                else
                {
                    break;
                }
            }*/

            n= (int)(-1+Math.Sqrt(1+8*star))/2;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
