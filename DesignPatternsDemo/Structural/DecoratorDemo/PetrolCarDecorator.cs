using System;
using System.Collections.Generic;
using System.Text;

namespace StructureDecoratorDemo
{
    class PetrolCarDecorator : CarDecorator
    {
        public PetrolCarDecorator(ICar1 car) : base(car)
        {
        }

        public override ICar1 ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return car;
        }

        public void AddEngine(ICar1 car)
        {
            if (car is BMWCar)
            {
                BMWCar BMWCar = (BMWCar)car;
                BMWCar.Engine = "Petrol Engine";
                Console.WriteLine("PetrolCarDecorator added Petrol Engine to the Car : " + car);
            }
        }
    }
}