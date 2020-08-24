using System;

namespace StructureDecoratorDemo
{
  public  class DecoratorDemo
    {
       public static void Start()
        {
            Console.WriteLine("Hello World!");
            ICar1 bmwCar1 = new BMWCar();
            bmwCar1.ManufactureCar();
            Console.WriteLine(bmwCar1 + "\n");
            ICar1 bmwCar2 = new BMWCar();
            PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
            carWithPetrolEngine.ManufactureCar();
            Console.ReadLine();

        }
    }
}