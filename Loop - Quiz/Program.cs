using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Total = 0, NumberOfOrder = 0;

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Java - 120");
            Console.WriteLine("2. Cappuccino - 100");
            Console.WriteLine("3. Cafe Latte - 110");
            Console.WriteLine("4. Brewed - 90");
            Console.WriteLine("5. Coffee Jelly - 115");
            Console.WriteLine("\nSize:");
            Console.WriteLine("S - Add 5");
            Console.WriteLine("M - Add 10");
            Console.WriteLine("L - Add 15");

            Console.Write("\nHow many orders? ");
            NumberOfOrder = Convert.ToInt32(Console.ReadLine());

            for (int counter = 1; counter <= NumberOfOrder; counter++)
            {
                Console.Write("Coffee order #" + counter + ": ");
                int order = Convert.ToInt32(Console.ReadLine());

                Console.Write("Size of order #" + counter + ": ");
                char size = Convert.ToChar(Console.ReadLine());

                int sum = Menu(order, size);
                Total += sum;     
            }
            Console.WriteLine("Total amount: " + Total);
        }

        public static int Menu(int Type, char Size)
        {
            int price = 0, add = 0;

            switch (Type)
            {
                case 1:
                    price = 120;
                    break;
                case 2:
                    price = 100;
                    break;
                case 3:
                    price = 110;
                    break;
                case 4:
                    price = 90;
                    break;
                case 5:
                    price = 115;
                    break;
            }

            switch (Size)
            {
                case 'S':
                case 's':
                    add = 5;
                    break;
                case 'M':
                case 'm':
                    add = 10;
                    break;
                case 'L':
                case 'l':
                    add = 15;
                    break;
            }

            return price + add;
        }
    }
}
