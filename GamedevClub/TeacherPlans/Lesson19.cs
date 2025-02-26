using System;
using System.Threading;

namespace GamedevClub.TeacherPlans
{
    public class Lesson19
    {
        public void MultithreadingExample()
        {
            Thread thread1 = new Thread(PrintNumbers);
            Thread thread2 = new Thread(PrintNumbers);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("All threads have finished execution.");
        }

        private void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: {i}");
                Thread.Sleep(500);
            }
        }
    }
}