using System;

namespace GamedevClub.TeacherPlans
{
    public class Lesson29
    {
        public void StructExample()
        {
            PlayerStats player = new PlayerStats("Alice", 100);
            player.Display();
        }
    }

    struct PlayerStats
    {
        public string Name;
        public int Score;

        public PlayerStats(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public void Display()
        {
            Console.WriteLine($"Player: {Name}, Score: {Score}");
        }
    }
}