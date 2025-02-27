using System;
using System.Threading.Tasks;

namespace GamedevClub.TeacherPlans
{
    public class Lesson20
    {
        public async Task AsyncExample()
        {
            Console.WriteLine("Starting data download...");
            string data = await DownloadDataAsync();
            Console.WriteLine($"Downloaded data: {data}");
        }

        private async Task<string> DownloadDataAsync()
        {
            await Task.Delay(2000);
            return "Sample Data";
        }
    }
}