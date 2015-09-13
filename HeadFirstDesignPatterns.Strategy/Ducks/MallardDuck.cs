using System;
using HeadFirstDesignPatterns.Strategy.FlyBehaviors;
using HeadFirstDesignPatterns.Strategy.QuackBehaviors;

namespace HeadFirstDesignPatterns.Strategy.Ducks
{
    internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
