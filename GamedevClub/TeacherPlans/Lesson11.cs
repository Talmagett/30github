using System;

namespace GamedevClub.TeacherPlans.Interfaces
{
    public class Lesson11
    {
        public void InterfaceExample()
        {
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();
            bicycle.Move();
        }
    }

    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The car is driving on the road.");
        }
    }

    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The bicycle is being pedaled.");
        }
    }
}