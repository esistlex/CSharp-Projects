using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable Initialization//
            String name;
            long contact_number;
            int months, years;
            double amount_loan;

            //User Input//
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Contact No.: ");
            contact_number = Convert.ToInt64(Console.ReadLine());
            Console.Write("Loan Amount: ");
            amount_loan = Convert.ToDouble(Console.ReadLine());
            Console.Write("No. of years: ");
            years = Convert.ToInt32(Console.ReadLine());

            //Conversion//
            double convertToLoanRate, convertToLoanable, convertToAmmortization;
            months = years * 12;
            convertToLoanRate = LoanRate(years);
            convertToLoanable = LoanableAmount(amount_loan);
            convertToAmmortization = Ammortization(convertToLoanable, convertToLoanRate, months);       
   
            //Output//
            Console.WriteLine("\n\nClient Name: " + name);
            Console.WriteLine("Contact No: " + contact_number);
            Console.WriteLine("Loan Amount: " + amount_loan);
            Console.WriteLine("No. of years: " + years + " or " + months + " months");
            Console.WriteLine("Loanable Amount: " + convertToLoanable);
            Console.WriteLine("Interest Rate: " + convertToLoanRate * 100 +"%");
            Console.WriteLine("Monthly Ammortization: " + convertToAmmortization);
            Console.ReadKey();
        }

        public static double LoanRate(int years)
        {
            double interest_rate = 0;
            switch (years)
            {
                case 3:
                    interest_rate = 0.22;
                    break;
                case 4:
                    interest_rate = 0.29;
                    break;
                case 5:
                    interest_rate = 0.38;
                    break;
                case 10:
                    interest_rate = 0.42;
                    break;
            }

            return interest_rate;
        }
        
        public static double LoanableAmount(double amount_loan)
        {
            double loanable_amount;
            loanable_amount = amount_loan * 0.80;
            return loanable_amount;
        }

        public static double Ammortization(double loanable_amount, double interest_rate, int months)
        {
            double monthly_ammortization = 0;
            monthly_ammortization = ((loanable_amount * interest_rate) + loanable_amount) / months;
            return monthly_ammortization;
        }
        
    }
}
