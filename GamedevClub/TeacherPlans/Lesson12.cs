using System;

namespace GamedevClub.TeacherPlans
{
    public class Lesson12
    {
        public void AbstractClassExample()
        {
            Animal[] animals = { new Dog(), new Cat() };

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
        }
    }

    public abstract class Animal
    {
        protected string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public abstract void MakeSound();
    }

    public class Dog : Animal
    {
        public Dog() : base("Dog") { }

        public override void MakeSound()
        {
            Console.WriteLine($"{name} says: Woof! Woof!");
        }
    }

    public class Cat : Animal
    {
        public Cat() : base("Cat") { }

        public override void MakeSound()
        {
            Console.WriteLine($"{name} says: Meow! Meow!");
        }
    }
}