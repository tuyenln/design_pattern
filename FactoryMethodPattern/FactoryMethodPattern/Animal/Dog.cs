using System;
namespace FactoryMethodPattern.Animal
{
    public class Dog : IAnimal
    {
        public string getName()
        {
            return "I am DOG";
        }
    }
}
