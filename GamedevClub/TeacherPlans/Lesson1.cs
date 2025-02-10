using System;
using System.Threading;

namespace GamedevClub.TeacherPlans
{
    public class Lesson1
    {
        public void While()
        {
            bool isAlive = true;
            int health = 10;
            int damage = 2;
            
            Console.WriteLine("Enemy health: " + health);
            Console.WriteLine("Press A to attack");
            Thread.Sleep(500);

            while (isAlive)
            {
                Thread.Sleep(500);
                ConsoleKey key = Console.ReadKey().Key;
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
            
            Console.WriteLine("Health: " + health);
            Thread.Sleep(500);

            int poisonDamage = 2;
            int ticks = 3;
            
            Console.WriteLine("You get poisoned");
            Thread.Sleep(500);

            for (var i = 0; i < ticks; i++)
            {
                health -= poisonDamage;
                Console.WriteLine("Health: " + health);
                Thread.Sleep(500);
            }
        }
    }
}