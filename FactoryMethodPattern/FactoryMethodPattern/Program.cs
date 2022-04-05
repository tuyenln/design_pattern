using System;
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
                factory = new BasicAnimalFactory();
            }
            else
            {
                factory = new RandomAnimalFactory();
            }

            //IAnimal animal = factory.createAnimal();

            Console.WriteLine(factory.createAnimal().getName());
            Console.WriteLine(factory.createAnimal().getName());
            Console.WriteLine(factory.createAnimal().getName());
            Console.WriteLine(factory.createAnimal().getName());
            Console.WriteLine(factory.createAnimal().getName());
            Console.WriteLine(factory.createAnimal().getName());
        }
    }
}