using System;
using System.Collections.Generic;

namespace GamedevClub.TeacherPlans
{
    public class Lesson26
    {
        public void HashSetExample()
        {
            HashSet<int> numbers = new HashSet<int> { 10, 20, 30, 40, 10, 20 };

            Console.WriteLine("Unique numbers:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            int checkNumber = 30;
            Console.WriteLine($"Contains {checkNumber}: {numbers.Contains(checkNumber)}");
        }
    }
}