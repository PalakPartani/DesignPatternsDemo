using System;

namespace FactoryPatternImpl
{
   public class FactoryDemo
    {
        public static void Start()
        {
            Console.WriteLine("Hello World!");
            IFactory factory = new VehicleFactory();
            IVehicle vehicle = factory.CreateObject("TwoWheeler");
            vehicle.Show();
            Console.ReadLine();
        }
    }
}
