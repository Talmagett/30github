using System;

namespace GamedevClub.TeacherPlans.Inheritance
{
    public class Lesson8
    {
        public void InheritanceExample()
        {
            Shape shape = new Shape("Generic Shape");
            Circle circle = new Circle();
            Square square = new Square();

            shape.Describe();
            circle.Describe();
            square.Describe();
        }
    }

    public class Shape
    {
        protected string name;

        public Shape(string name)
        {
            this.name = name;
        }

        public virtual void Describe()
        {
            Console.WriteLine($"This is a {name}.");
        }
    }

    public class Circle : Shape
    {
        public Circle() : base("Circle") { }

        public override void Describe()
        {
            Console.WriteLine($"This is a {name}. It has no corners.");
        }
    }

    public class Square : Shape
    {
        public Square() : base("Square") { }

        public override void Describe()
        {
            Console.WriteLine($"This is a {name}. It has four equal sides.");
        }
    }
}