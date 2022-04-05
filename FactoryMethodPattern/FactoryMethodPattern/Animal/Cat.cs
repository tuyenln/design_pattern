using System;
namespace FactoryMethodPattern.Animal
{
    public class Cat : IAnimal
    {
        public string getName()
        {
            return "I am CAT";
        }
    }
}
