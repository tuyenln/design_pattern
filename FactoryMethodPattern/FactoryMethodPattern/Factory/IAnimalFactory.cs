using System;
using FactoryMethodPattern.Animal;

namespace FactoryMethodPattern.Factory
{
    public interface IAnimalFactory
    {
        IAnimal createAnimal();
    }
}
