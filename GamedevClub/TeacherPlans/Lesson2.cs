using System;

namespace GamedevClub.TeacherPlans
{
    public class Lesson2
    {
        public void CheckEvenOrOdd()
        {
            Console.Write("Input number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Number is even!");
                }
                else
                {
                    Console.WriteLine("Number is odd!");
                }
            }
            else
            {
                Console.WriteLine("Number is not correct");
            }
        }
    }
}
