using System;
using System.IO;
using Newtonsoft.Json;

namespace GamedevClub.TeacherPlans.Json
{
    public class Lesson22
    {
        private const string FilePath = "player.json";

        public void JsonExample()
        {
            Player player = new Player("John", 150);
            string json = JsonConvert.SerializeObject(player, Formatting.Indented);

            File.WriteAllText(FilePath, json);
            Console.WriteLine("JSON saved successfully.");

            string readJson = File.ReadAllText(FilePath);
            Player loadedPlayer = JsonConvert.DeserializeObject<Player>(readJson);

            Console.WriteLine($"Loaded Player: {loadedPlayer.Name} - Score: {loadedPlayer.Score}");
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}