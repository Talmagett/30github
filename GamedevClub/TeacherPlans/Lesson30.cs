using System;

namespace GamedevClub.TeacherPlans.Game
{
    public class Lesson30
    {
        public void StartGame()
        {
            Player player = new Player("Hero", 100);
            Monster monster = new Monster("Goblin", 50);

            Console.WriteLine($"Battle: {player.Name} vs {monster.Name}");

            while (player.Health > 0 && monster.Health > 0)
            {
                player.Attack(monster);
                if (monster.Health > 0)
                {
                    monster.Attack(player);
                }
            }

            Console.WriteLine(player.Health > 0 ? "You win!" : "Game over.");
        }
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public virtual void Attack(Character enemy)
        {
            int damage = new Random().Next(5, 15);
            enemy.Health -= damage;
            Console.WriteLine($"{Name} attacks {enemy.Name} for {damage} damage.");
        }
    }

    class Player : Character
    {
        public Player(string name, int health) : base(name, health) { }
    }

    class Monster : Character
    {
        public Monster(string name, int health) : base(name, health) { }
    }
}