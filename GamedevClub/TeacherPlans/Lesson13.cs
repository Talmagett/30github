using System;

namespace GamedevClub.TeacherPlans
{
    public class Lesson13
    {
        public void StaticClassExample()
        {
            Console.WriteLine($"Addition: {MathUtils.Add(5, 3)}");
            Console.WriteLine($"Subtraction: {MathUtils.Subtract(10, 4)}");
            Console.WriteLine($"Multiplication: {MathUtils.Multiply(6, 7)}");
            Console.WriteLine($"Division: {MathUtils.Divide(20, 5)}");
        }
    }

    public static class MathUtils
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero!");
                return double.NaN;
            }
            return a / b;
        }
    }
}