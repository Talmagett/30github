using System;
using System.Collections.Generic;

namespace GamedevClub.TeacherPlans
{
    public class Lesson5
    {
        public void SumNumbersInList()
        {
            List<int> numbers = new List<int>();
            string input;

            Console.WriteLine("Enter numbers (type 'stop' to finish):");

            while (true)
            {
                Console.Write("Enter a number: ");
                input = Console.ReadLine();

                if (input.ToLower() == "stop")
                    break;

                if (int.TryParse(input, out int num))
                {
                    numbers.Add(num);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            int sum = 0;
            foreach (int num in numbers) sum += num;

            Console.WriteLine($"Total sum: {sum}");
        }
    }
}