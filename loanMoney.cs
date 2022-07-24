using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDivision
{
    internal class loanMoney
    {
        static void MainM()
        {
            int months;
            double enter_rate, loan;
            Console.Write("Enter Money Loan=$");
            loan = double.Parse(Console.ReadLine());
            Console.Write("Enter inerest rate=%");
            enter_rate = double.Parse(Console.ReadLine());
            Console.Write("Enter month=");
            months = int.Parse(Console.ReadLine());
            Console.WriteLine("Month \t\tInstallment\tInterest\tDebit");
            double rate = enter_rate / 100;
            double installment = (loan * rate) / (1 - (Math.Pow((1 + rate), -months)));
            double total_interest=0, total_installment=0;
            for (int i = 1; i <= months; i++)
            {
                double interest = loan * rate;
                double debit = loan - (installment - interest);
                Console.WriteLine($"Month: {i}\t{installment:c2}\t\t{interest:c2}\t\t{debit:c2}");
                loan = debit;
                total_interest += interest;
                total_installment += installment;
            }
            Console.WriteLine("========================================================");
            Console.WriteLine($"Total interest: {total_interest:c2}");
            Console.WriteLine($"Total instllment: {total_installment:c2}");
            Console.ReadKey();
        }
    }
}
