using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDivision
{
    internal class Fibonaci
    {
        static void MainV()
        {
            int n, m=0,l=1,f;
            //String str = " ";
            Console.Write("Enter n=");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                /*m = i;
                if(i>=1){
                    m = i;
                }
                else
                {
                    str += $"{m}, ";
                }*/
                if (i == 1)
                {
                    Console.Write($"{m}, ");
                }else if (i == 2)
                {
                    Console.Write($"{l}, ");
                }
                else
                {
                    f = m + l;
                    Console.Write($"{f}, ");
                    m = l;
                    l = f;
                }
            }
            //Console.Write($"{str}\b\b{str.Remove(1)}\n");
            Console.ReadKey();
        }
    }
}
