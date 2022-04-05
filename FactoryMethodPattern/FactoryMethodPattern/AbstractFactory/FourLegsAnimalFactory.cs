using System;
using FactoryMethodPattern.Animal;

namespace FactoryMethodPattern.AbstractFactory
{
    class FourLegsAnimalFactory : AbstractAnimalFactory
    {
        public override IAnimal createAnimal()
        {
            Random random = new Random();
            int type = random.Next(0, 2);
            if (type == 0)
            {
                return new Dog();
            }
            else
            {
                return new Cat();
            }
        }
    }
}
