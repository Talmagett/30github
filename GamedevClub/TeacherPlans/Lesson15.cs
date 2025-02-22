using System;

namespace GamedevClub.TeacherPlans
{
    public class Lesson15
    {
        public void DelegateExample()
        {
            OperationDelegate operation;

            operation = MathOperations.Sum;
            Console.WriteLine($"Sum: {operation(10, 5)}");

            operation = MathOperations.Subtract;
            Console.WriteLine($"Subtract: {operation(10, 5)}");

            operation = MathOperations.Multiply;
            Console.WriteLine($"Multiply: {operation(10, 5)}");

            operation = MathOperations.Divide;
            Console.WriteLine($"Divide: {operation(10, 5)}");
        }
    }

    public delegate double OperationDelegate(double a, double b);

    public static class MathOperations
    {
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
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