using System;

namespace GamedevClub.TeacherPlans
{
    public class Lesson23
    {
        public void ExceptionHandlingExample()
        {
            try
            {
                Console.WriteLine("Enter a number to divide 100:");
                int divisor = int.Parse(Console.ReadLine());

                int result = 100 / divisor;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number.");
            }
            finally
            {
                Console.WriteLine("Operation complete.");
            }
        }
    }
}