using System;

namespace GamedevClub.TeacherPlans
{
    public class Lesson16
    {
        public void EventExample()
        {
            Player player = new Player(100);
            UI ui = new UI();

            player.OnHealthChanged += ui.DisplayHealth;

            player.TakeDamage(20);
            player.TakeDamage(30);
            player.TakeDamage(50);
        }
    }

    public class Player
    {
        public event Action<int> OnHealthChanged;
        private int health;

        public Player(int initialHealth)
        {
            health = initialHealth;
            Console.WriteLine($"Player created with {health} HP.");
        }

        public void TakeDamage(int damage)
        {
            health -= damage;
            Console.WriteLine($"Player takes {damage} damage!");
            OnHealthChanged?.Invoke(health);
        }
    }

    public class UI
    {
        public void DisplayHealth(int health)
        {
            Console.WriteLine($"Player's current health: {health}");
        }
    }
}