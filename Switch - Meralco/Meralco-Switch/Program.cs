namespace Switch_Meralco
{
    class Program
    {
        static void Main(string[] args)
        {
            double hours, watts, rate = 0, kWh, AccountTypeBill, TotalBill = 0;
            char inputA, inputB;

            //Enter watts and hours
            Console.Write("Enter Watts: ");
            watts = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter daily usage in hours: ");
            hours = Convert.ToDouble(Console.ReadLine());

            //Enter account type
            Console.WriteLine("Choose one of the following options:");
            Console.WriteLine("A. Residential\nB. Commercial");
            Console.Write(">>");
            inputA = Convert.ToChar(Console.ReadLine());

            kWh = (watts * hours) / 1000;

            switch (inputA)
            {
                case 'A' or 'a':
                    rate = 11.9112;
                    break;
                case 'B' or 'b':
                    rate = 12.3261;
                    break;
            }
            AccountTypeBill = kWh * rate;

            //Enter billing period
            Console.WriteLine("Choose billing period:");
            Console.WriteLine("A. Monthly\nB. Annually");
            Console.Write(">>");
            inputB = Convert.ToChar(Console.ReadLine());

            switch (inputB)
            {
                case 'A' or 'a':
                    TotalBill = AccountTypeBill * 30;
                    break;
                case 'B' or 'b':
                    TotalBill = AccountTypeBill * 365;
                    break;
            }

            //Result
            Console.WriteLine("\nYour daily kWh is: " + kWh + "/kWh");
            Console.WriteLine("Your total bill is: " + TotalBill);
        }
    }
}