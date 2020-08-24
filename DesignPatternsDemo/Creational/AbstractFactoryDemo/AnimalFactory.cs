using System;
using System.Collections.Generic;
using System.Text;

namespace abstractFactoryDemo
{
    /// <summary>
    /// Main abstract class to provide obj for two factory classes.
    /// </summary>
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(string AnimalType);
        public static AnimalFactory CreateAnimalFactory(string FactoryType)
        {
            if (FactoryType.Equals("Air"))
                return new AirAnimalFactory();
            else
                return new LandAnimalFactory();
        }
    }
}
