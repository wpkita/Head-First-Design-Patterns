using System;

namespace HeadFirstDesignPatterns.Strategy.FlyBehaviors
{
    internal class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
