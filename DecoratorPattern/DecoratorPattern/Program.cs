using System;
using DecoratorPattern.Base;
using DecoratorPattern.Decorators;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var ourMilkTea = new EggPudding(new FruitPudding(new BlackSugar(new Bubble(new MilkTea()))));

            Console.WriteLine(ourMilkTea.Cost());

            var secondMilkTea = new EggPudding(new BlackSugar(new WhiteBubble(new MilkTea())));

            Console.WriteLine(secondMilkTea.Cost());
        }
    }
}
