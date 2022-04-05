using System;
namespace FactoryMethodPattern.Animal
{
    public class Dog : FourLegAnimal
    {
        public override string getName()
        {
            return "I am DOG";
        }
    }
}
