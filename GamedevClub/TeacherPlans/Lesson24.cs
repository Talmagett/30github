using System;
using System.Collections.Generic;

namespace GamedevClub.TeacherPlans
{
    public class Lesson24
    {
        public void StackExample()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine($"Stack count: {stack.Count}");

            while (stack.Count > 0)
            {
                int item = stack.Pop();
                Console.WriteLine($"Popped: {item}");
            }

            Console.WriteLine($"Stack is empty: {stack.Count == 0}");
        }
    }
}