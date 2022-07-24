using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDivision
{
    internal class LoanDownMoney
    {
        static void Main()
        {
            string symbol = "*************************************************************************************************************";
            int months;
            double rate, loan,total_installment=0,total_interest=0;
            Console.Write("Enter Money Loan=$");
            loan = double.Parse(Console.ReadLine());
            Console.Write("Enter inerest rate=%");
            rate = double.Parse(Console.ReadLine());
            Console.Write("Enter month=");
            months = int.Parse(Console.ReadLine());
            rate /= 100;
            double amortized_principle = loan / months;
            Console.WriteLine(symbol);
            Console.Write("*".PadRight(5));
            Console.Write("Month".PadRight(10));
            Console.Write("*".PadLeft(2));
            Console.Write("Principle".PadLeft(15));
            Console.Write("*".PadLeft(8));
            Console.Write("Interest".PadLeft(15));
            Console.Write("*".PadLeft(8));
            Console.Write("Installment".PadLeft(15));
            Console.Write("*".PadLeft(8));
            Console.Write("Balance".PadLeft(15));
            Console.Write("*".PadLeft(8));
            Console.WriteLine($"\n{symbol}");
            for (int i = 1; i <= months; i++)
            {
                double interest_month = loan * rate;
                double ins_per_month = amortized_principle + interest_month;
                loan -= amortized_principle;
                Console.Write("*".PadRight(5));
                Console.Write($"{i}".PadRight(10));
                Console.Write("*".PadLeft(2));
                Console.Write($"{amortized_principle:c2}".PadLeft(15));
                Console.Write("*".PadLeft(8));
                Console.Write($"{interest_month:c2}".PadLeft(15));
                Console.Write("*".PadLeft(8));
                Console.Write($"{ins_per_month:c2}".PadLeft(15));
                Console.Write("*".PadLeft(8));
                Console.Write($"{loan:c2}".PadLeft(15));
                Console.Write("*".PadLeft(8));
                Console.WriteLine();
                total_installment += ins_per_month;
                total_interest += interest_month;
            }
            Console.WriteLine(symbol);
            Console.Write("*".PadRight(2));
            Console.Write("Total Installment".PadRight(10));
            Console.Write("*".PadLeft(7));
            Console.Write($"{total_installment:c2}".PadLeft(15));
            Console.Write("*".PadLeft(8));
            Console.WriteLine("\n*************************************************");
            Console.Write("*".PadRight(2));
            Console.Write("Total Interest".PadRight(10));
            Console.Write("*".PadLeft(10));
            Console.Write($"{total_interest:c2}".PadLeft(15));
            Console.Write("*".PadLeft(8));
            Console.WriteLine("\n*************************************************");
            Console.ReadKey();
        }
    }
}
