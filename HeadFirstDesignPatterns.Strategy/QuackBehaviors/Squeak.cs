using System;

namespace HeadFirstDesignPatterns.Strategy.QuackBehaviors
{
    internal class Squeak : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
