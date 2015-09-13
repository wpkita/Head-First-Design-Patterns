﻿using System;

namespace HeadFirstDesignPatterns.Strategy.FlyBehaviors
{
    internal class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
