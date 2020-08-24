using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternImpl
{
   public class VehicleFactory : IFactory
    {
        public IVehicle CreateObject(string className)
        {
            if (className == "TwoWheeler")
            {
                return new TwoWheeler();
            }
            if (className == "FourWheeler")
            {
                return new FourWheeler();
            }
            return null;
        }
    }
}
