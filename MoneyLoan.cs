using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDivision
{
    internal class MoneyLoan
    {
        static void MainLoan()
        {
            int months;
            double rate, loan;
            Console.Write("Enter Money Loan=$");
            loan = double.Parse(Console.ReadLine());
            Console.Write("Enter inerest rate=%");
            rate = double.Parse(Console.ReadLine());
            Console.Write("Enter month=");
            months = int.Parse(Console.ReadLine());

            rate /= 100;
            double installment = (loan * rate) / (1 - (Math.Pow((1 + rate), -months)));
            Console.Write("Month".PadRight(10));
            Console.Write("Installment".PadLeft(15));
            Console.Write("Principal".PadLeft(15));
            Console.Write("Interest".PadLeft(15));
            Console.Write("Debt".PadLeft(15));
            Console.WriteLine();
            double principal,totalInterest=0;
            double interest, debtpayment = loan;
            for (int i = 1; i <= months; i++)
            {
                interest = debtpayment * rate;
                principal = installment - interest;
                debtpayment-= principal;
                if (i == months)
                {
                    interest = Math.Round(installment, 2) - Math.Round(principal, 2);
                }
                Console.Write($"Month {i}".PadRight(10,'-'));
                Console.Write($"{installment:c2}".PadLeft(15,'-'));
                Console.Write($"{principal:c2}".PadLeft(15,'-'));
                Console.Write($"{interest:c2}".PadLeft(15,'-'));
                Console.Write($"{debtpayment:c2}".PadLeft(15,'-'));
                Console.WriteLine();
                totalInterest+=interest;
            }
            double totalInstallment = loan + totalInterest;
            Console.WriteLine("======================================================================");
            Console.WriteLine($"Total interest: {totalInterest:c2}");
            Console.WriteLine($"Total installment: {totalInstallment:c2}");
            Console.ReadKey();
        }
    }
}
