﻿using System;

namespace HeadFirstDesignPatterns.Strategy.FlyBehaviors
{
    internal class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }
}
