using System;

namespace GamedevClub.TeacherPlans.Polymorphysm
{
    public class Lesson9
    {
        public void PolymorphismExample()
        {
            Shape[] shapes = { new Circle(5), new Square(4) };

            foreach (Shape shape in shapes)
            {
                shape.Describe();
                Console.WriteLine($"Area: {shape.CalculateArea()}\n");
            }
        }
    }

    public abstract class Shape
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

        public abstract double CalculateArea();
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius) : base("Circle")
        {
            this.radius = radius;
        }

        public override void Describe()
        {
            Console.WriteLine($"This is a {name}. It has no corners.");
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Square : Shape
    {
        private double side;

        public Square(double side) : base("Square")
        {
            this.side = side;
        }

        public override void Describe()
        {
            Console.WriteLine($"This is a {name}. It has four equal sides.");
        }

        public override double CalculateArea()
        {
            return side * side;
        }
    }
}