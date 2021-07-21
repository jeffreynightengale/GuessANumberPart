using System;

namespace Participation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user, please input your min value. >>");
            string min = Console.ReadLine();

            Console.WriteLine("Please input your max value. >>");
            string max = Console.ReadLine();

            int minValue;
            int maxValue;

            if (int.TryParse(min, out minValue) != true)
            {
                Console.WriteLine("Please input a number.");
                Environment.Exit(1);
            }

            if (int.TryParse(max, out maxValue) != true)
            {
                Console.WriteLine("Please input a valid number.");
                Environment.Exit(1);
            }


            int number;
            int guess;
            do
            {

            Random rand = new Random();
            number = rand.Next(minValue, maxValue + 1);
            
            Console.WriteLine("Now, take a guess between your minimum and your maximum. >>");
            string guessedNumber = Console.ReadLine();
                if (int.TryParse(guessedNumber, out guess) != true)
                {
                    Console.WriteLine("Please input a valid number.");
                    return;
                }
            
            Console.WriteLine($"You guessed ({guess}) and the random number is ({number}).");

            if (guess == number)
            {
                Console.WriteLine("Congratulations, you got the correct number!");
            }
            else
            {
                Console.WriteLine("You got it wrong! Try again!");
            }
            } while (guess != number);
        }
    }
}
