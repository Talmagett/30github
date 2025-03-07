using System;

namespace GamedevClub.TeacherPlans
{
    public class Lesson28
    {
        public void TupleExample()
        {
            var player = ("Alice", 25, 100.5);
            Console.WriteLine($"Player: {player.Item1}, Age: {player.Item2}, Score: {player.Item3}");

            var gameResult = GetGameResult();
            Console.WriteLine($"Winner: {gameResult.winner}, Score: {gameResult.score}");
        }

        private (string winner, int score) GetGameResult()
        {
            return ("Bob", 150);
        }
    }
}