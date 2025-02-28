using System;
using System.IO;

namespace GamedevClub.TeacherPlans
{
    public class Lesson21
    {
        public void FileHandlingExample()
        {
            string filePath = "data.txt";
            string content = "Hello, this is a test file!";

            File.WriteAllText(filePath, content);
            Console.WriteLine("File written successfully.");

            string readContent = File.ReadAllText(filePath);
            
            Console.WriteLine($"File content: {readContent}");
        }
    }
}