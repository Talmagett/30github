using System;

namespace GamedevClub.TeacherPlans
{
    public class Lesson4
    {
        public void MinMaxInArray()
        {
            int[] numbers = new int[5];

            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write($"Number {i + 1}: ");
                }
            }

            int min = numbers[0], max = numbers[0];

            foreach (int num in numbers)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }

            Console.WriteLine($"Minimum number: {min}");
            Console.WriteLine($"Maximum number: {max}");
        }
    }
}