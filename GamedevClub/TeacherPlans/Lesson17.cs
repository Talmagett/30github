using System;
using System.Collections.Generic;
using System.Linq;

namespace GamedevClub.TeacherPlans
{
    public class Lesson17
    {
        public void LambdaExample()
        {
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine($"Addition using lambda: {add(10, 5)}");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            Console.WriteLine("Even numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}