using System;
namespace FactoryMethodPattern.Animal
{
    public class Duck : TwoLegAnimal
    {

        public override string getName()
        {
            return "I am DUCK";
        }
    }
}
