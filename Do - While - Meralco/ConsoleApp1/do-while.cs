using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double grades = 0, score = 0, average = 0;
            int items, counter;
            char answer = '\0';
            do
            {
                Console.Clear();
                for (counter = 1; counter <= 5; counter++)
                {
                    Console.Write("[" + counter + "]" + "Enter raw score: ");
                    score = Convert.ToInt32(Console.ReadLine());
                    Console.Write("[" + counter + "]" + "Enter raw items: ");
                    items = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    grades = grades + ConvertScore(score, items);
                    counter++;
                }
                Console.WriteLine("Total grade is: " + (grades / 5));
                Console.WriteLine("Do you want to continue? Enter (Y) to continue.");
                answer = Convert.ToChar(Console.ReadLine());
            } while (answer == 'Y' || answer == 'y');
            Console.ReadKey();
        }

        public static double ConvertScore(double rawscore, int items)
        {
            double grade;
            grade = (rawscore / items) * 50 + 50;
            return grade;
        }
    }
}