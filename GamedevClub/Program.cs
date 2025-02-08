using System;
using System.Threading;

namespace GamedevClub
{
    internal class Program
    {
        public static void Main(string[] args)
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