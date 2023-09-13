using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double grades = 0, score = 0, average = 0;
            int counter, limit, items = 0;
            char answer = '\0';

            do
            {
                Console.Clear();
                counter = 1;
                average = 0;

                Console.Write("How many times to loop? ");
                limit = Convert.ToInt32(Console.ReadLine());

                while (counter <= limit)
                {
                    Console.Write("[" + counter + "]" + "Enter raw score: ");
                    score = Convert.ToInt32(Console.ReadLine());
                    Console.Write("[" + counter + "]" + "Enter raw items: ");
                    items = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    grades = grades + ConvertScore(score, items);
                    counter++;
                }
                Console.WriteLine("\nTotal grade is: " + (grades / limit));
                Console.WriteLine("Do you want to continue? Enter (Y) to continue.");
                answer = Convert.ToChar(Console.ReadLine());
            }
            while (answer == 'Y' || answer == 'y');
            Console.ReadLine();
        }

        public static double ConvertScore(double rawscore, int items)
        {
            double grade;
            grade = (rawscore / items) * 50 + 50;
            return grade;
        }
    }
}
