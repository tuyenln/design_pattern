using System;
using FactoryMethodPattern.Animal;
using FactoryMethodPattern.Factory;

namespace FactoryMethodPattern.AbstractFactory
{
    abstract class AbstractAnimalFactory : IAnimalFactory
    {
        public abstract IAnimal createAnimal();
    }
}
