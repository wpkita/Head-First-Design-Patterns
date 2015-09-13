using System;
using HeadFirstDesignPatterns.Strategy.FlyBehaviors;
using HeadFirstDesignPatterns.Strategy.QuackBehaviors;

namespace HeadFirstDesignPatterns.Strategy.Ducks
{
    internal abstract class Duck
    {
        public IFlyBehavior FlyBehavior { protected get; set; }
        public IQuackBehavior QuackBehavior { protected get; set; }

        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.DoQuack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
