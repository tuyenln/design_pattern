﻿using System;
using DecoratorPattern.Base;

namespace DecoratorPattern.Decorators
{
    public class FruitPudding : MilkTeaDecorator
    {
        public FruitPudding(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 3d +  base.Cost();
        }
    }
}
