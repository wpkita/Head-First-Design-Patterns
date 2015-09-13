using System;

namespace HeadFirstDesignPatterns.Strategy.QuackBehaviors
{
    internal class Quack : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Quack");
        }
    }
}
