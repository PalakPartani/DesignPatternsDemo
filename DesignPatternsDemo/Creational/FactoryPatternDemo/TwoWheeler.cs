using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternImpl
{
    class TwoWheeler: IVehicle
    {
        public void Show()
        {
            Console.WriteLine("Inside two wheeler");
        }
    }
}
