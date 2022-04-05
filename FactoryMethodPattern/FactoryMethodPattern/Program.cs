using System;
using FactoryMethodPattern.AbstractFactory;
using FactoryMethodPattern.Animal;
using FactoryMethodPattern.Factory;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory factory;

            Random random = new Random();
            int type = random.Next(0, 2);

            if (type == 0)
            {
                factory = new FourLegsAnimalFactory();
            }
            else
            {
                factory = new TwoLegsAnimalFactory();
            }

            Console.WriteLine(factory.createAnimal().getName());
            Console.WriteLine(factory.createAnimal().getName());
            Console.WriteLine(factory.createAnimal().getName());
            Console.WriteLine(factory.createAnimal().getName());
            Console.WriteLine(factory.createAnimal().getName());

        }
    }
}