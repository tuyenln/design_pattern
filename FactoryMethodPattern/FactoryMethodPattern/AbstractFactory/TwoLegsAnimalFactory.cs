using System;
using FactoryMethodPattern.Animal;

namespace FactoryMethodPattern.AbstractFactory
{
    class TwoLegsAnimalFactory : AbstractAnimalFactory
    {
        public override IAnimal createAnimal()
        {
            Random random = new Random();

            int type = random.Next(0, 2);
            if (type == 0)
            {
                return new Duck();
            }
            else
            {
                return new Dog();
            }
        }
    }
}
