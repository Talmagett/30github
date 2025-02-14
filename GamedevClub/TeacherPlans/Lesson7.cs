using System;

namespace GamedevClub.TeacherPlans
{
    public class Lesson7
    {
        public void OOPIntroduction()
        {
            Shape circle = new Shape("Circle");
            Shape square = new Shape("Square");

            circle.Describe();
            square.Describe();
        }
    }

    public class Shape
    {
        private string name;

        public Shape(string name)
        {
            this.name = name;
        }

        public void Describe()
        {
            Console.WriteLine($"This is a {name}.");
        }
    }
}