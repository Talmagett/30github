using System;
using System.Collections.Generic;

namespace GamedevClub.TeacherPlans
{
    public class Lesson25
    {
        public void QueueExample()
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Player 1");
            queue.Enqueue("Player 2");
            queue.Enqueue("Player 3");

            Console.WriteLine($"Queue count: {queue.Count}");

            while (queue.Count > 0)
            {
                string player = queue.Dequeue();
                Console.WriteLine($"Processing: {player}");
            }

            Console.WriteLine($"Queue is empty: {queue.Count == 0}");
        }
    }
}