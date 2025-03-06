using System;
using System.Collections.Generic;

namespace GamedevClub.TeacherPlans
{
    public class Lesson27
    {
        public void DictionaryExample()
        {
            Dictionary<int, string> players = new Dictionary<int, string>
            {
                {1, "Alice"},
                {2, "Bob"},
                {3, "Charlie"}
            };

            Console.WriteLine("All players:");
            foreach (var player in players)
            {
                Console.WriteLine($"ID: {player.Key}, Name: {player.Value}");
            }

            int searchId = 2;
            if (players.TryGetValue(searchId, out string name))
            {
                Console.WriteLine($"Player found: {name}");
            }
            else
            {
                Console.WriteLine("Player not found.");
            }
        }
    }
}