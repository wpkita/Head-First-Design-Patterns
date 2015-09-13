using System;

namespace HeadFirstDesignPatterns.Strategy.QuackBehaviors
{
    internal class MuteQuack : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
