using System;
using System.Collections.Generic;
using System.Text;

namespace abstractFactoryDemo
{
    public class AirAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Pigeon"))
            {
                return new Pigeon();
            }
            else
                return null;
        }
    }
}