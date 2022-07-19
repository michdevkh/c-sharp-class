using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDivision
{
    internal class PrimeNumber
    {
        static void MainM()
        {
            Console.WriteLine("************* Prime Number Application*************");
            int n;
            Console.Write("Enter n=");
            n=int.Parse(Console.ReadLine());
            bool isprime;
            string txt = " ";

            for (int x = 2; x <= n; x++)
            {
                isprime = true;
                for (int i = 2; i <= x / 2; i++)
                {
                    if ((x % i) == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                    txt += $"{x},";
            }
            Console.WriteLine("--------Output Prime Number----------");
            Console.Write($"Number: {n} has prime number: {txt}\b{txt.Remove(1)}\n");
            Console.WriteLine("\n*************End Application*************");
            Console.ReadKey();
        }
    }
}
