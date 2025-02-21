using System;

namespace GamedevClub.TeacherPlans
{
    public class Lesson14
    {
        public void OverloadingExample()
        {
            Console.WriteLine($"Add two numbers: {Calculator.Add(5, 3)}");
            Console.WriteLine($"Add three numbers: {Calculator.Add(5, 3, 2)}");
            Console.WriteLine($"Add four numbers: {Calculator.Add(5, 3, 2, 1)}");
        }
    }

    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }
}