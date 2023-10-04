using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ARRAY
            string[] name = {"Raphael", "Angelo", "Rayzen", "Moyo", "Julius", "Raven", "Stephanie"};
            int[] contact = {1234567, 4582484, 4583972, 2897261, 2789315, 4829329, 0398934};
            int[] active = {1, 0, 1, 0, 1, 1, 0};
            */


            /* FOREACH
            Console.Write("Enter name to search: ");
            String searchentry = Console.ReadLine(); 
             
            foreach (String searchvalue in name){
                if (searchvalue == searchentry)
                {
                    Console.WriteLine("Name found in the list.");
                }
                else
                {
                    Console.WriteLine("Name not found in the list.");
                }
            } */

            /* DO-WHILE
            Console.Write("Enter name to search: ");
            String searchentry = Console.ReadLine(); 
            int counter = 0;
            do{
            if (searchvalue == name [counter]){
                Console.WriteLine("Name found in list.");
            }
            else
            {
                Console.WriteLine("Name not found in the list.");
            }
            counter++;
            } while (searchvalue != name[counter-1]); */

            /* ArrayFind
            String searchvalue = Array.Find(name, element => element == searchentry);
            if (searchvalue != null)
            {
                Console.WriteLine("Name found in the list.");
            }
            else
            {
                Console.WriteLine("Name not found in the list.");
            }
             */

            /* BinarySearch
            Console.Write("Enter contact no. to search: ");
            int searchentry = Convert.ToInt32(Console.ReadLine()); 

            double searchvalue = Array.BinarySearch(contact, searchentry);
            Console.Write("Index is " +searchvalue);
            */

            /* SORT
            Array.Sort(name);
            foreach (String outputname in name)
            {
                Console.WriteLine(outputname);
            }
            */

            /* REVERSE SORT
            Array.Reverse(contact);
            foreach (int outputcontact in contact)
            {
                Console.WriteLine(outputcontact);
            }
            */

            /* 2D Array
            String[,] animals = { { "Dog", "Snake", "Cat" } , {"Bird", "Chicken", "Eagle"} };
            foreach (string outputanimals in animals)
            {
                Console.WriteLine(outputanimals);
            }
            */

            /*
            String[,] animals = new String[3, 3];

            animals[0, 0] = "Land animals:";
            animals[0, 1] = "Dog";
            animals[0, 2] = "Cow";

            for (int counter = 0; counter <= 2; counter++)
            {
                Console.WriteLine(animals[0, counter]);
            }
            */

            int input_number = 0;
            Console.Write("Enter number: ");
            input_number = Convert.ToInt32(Console.ReadLine());
            ConvertNumber(input_number);
            
            Console.ReadKey();
        }

        static void ConvertNumber(int input_number){
            string[,] NumbersToWords = {
                { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" },
                { "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" },
                { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" }
            };

            if (input_number == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (input_number > 0 && input_number <= 9)
            {
                Console.WriteLine(NumbersToWords[0, input_number - 1]);
            }
            else if (input_number > 9 && input_number <= 19)
            {
                Console.WriteLine(NumbersToWords[2, input_number - 11]);
            }
            else //if (input_number <= 99)
            {
                
                int tens = input_number / 10;
                int ones = input_number % 10;

                if(ones == 0){

                    Console.WriteLine(NumbersToWords[1, tens - 1]);
                }
                else
                {
                    Console.WriteLine(NumbersToWords[1, tens - 1] + "-" + NumbersToWords[0, ones - 1]);
                }
            }
            /* else if (input_number >= 99)
            {
                int tens = input_number / 10;
                int ones = input_number % 10;
                int hundreds = input_number / 100;
                int hundred_ones = input_number % 100;
                if (hundred_ones == 0)
                {
                    Console.WriteLine(NumbersToWords[0, hundreds - 1] + " hundred");
                }
                else
                {
                    Console.WriteLine(NumbersToWords[0, hundreds - 1] + " " + NumbersToWords[1, tens - 1] + "-" + NumbersToWords[0, ones - 1]);
                }
            } */
        }
    }
}
