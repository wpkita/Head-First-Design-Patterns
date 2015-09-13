using System;
using HeadFirstDesignPatterns.Strategy.Ducks;
using HeadFirstDesignPatterns.Strategy.FlyBehaviors;

namespace HeadFirstDesignPatterns.Strategy
{
    internal class Program
    {
        private static void Main()
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();

            Console.Read();
        }
    }
}
