using System;

namespace GamedevClub.TeacherPlans
{
    public class Lesson3
    {
        public void GuessTheNumber()
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("The secret number is between 1 and 100.");

            while (guess != secretNumber)
            {
                Console.Write("Input number: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                attempts++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("My number is greater.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("My number is less.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number {guess} in {attempts} attempts.");
                }
            }
        }
    }
}