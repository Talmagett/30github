using System;
using System.Threading;

namespace GamedevClub.TeacherPlans
{
    public class Lesson1
    {
        public void While()
        {
            var isAlive = true;
            var health = 10;
            Console.WriteLine("Enemy health: " + health);
            Thread.Sleep(500);
            var damage = 2;

            while (isAlive)
            {
                Thread.Sleep(500);
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.A)
                {
                    health -= damage;
                    Console.WriteLine($"You attacked enemy {damage} dmg. His health {health} ");
                }

                if (health <= 0) isAlive = false;
            }

            Console.WriteLine("You win");
        }

        public void For()
        {
            int health = 10;
            System.Console.WriteLine("Health: " + health);
            Thread.Sleep(500);

            int poisonDamage = 2;
            int ticks = 3;
            System.Console.WriteLine("You get poisoned");
            Thread.Sleep(500);
            
            for (int i = 0; i < ticks; i++)
            {
                health -= poisonDamage;
                System.Console.WriteLine("Health: " + health);
                Thread.Sleep(500);
            }
        }
    }
}