using System;
namespace FactoryMethodPattern.Animal
{
    public class Cat : FourLegAnimal
    {
        public override string getName()
        {
            return "I am CAT";
        }
    }
}
