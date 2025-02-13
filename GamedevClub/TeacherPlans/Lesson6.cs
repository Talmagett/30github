using System;

namespace GamedevClub.TeacherPlans
{
    public class Lesson6
    {
        public void SumWithFunction()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = CalculateSum(num1, num2);

            Console.WriteLine($"Sum: {result}");
        }

        private int CalculateSum(int a, int b)
        {
            return a + b;
        }
    }
}