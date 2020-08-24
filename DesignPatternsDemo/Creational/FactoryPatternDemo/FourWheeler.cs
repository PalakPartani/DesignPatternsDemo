using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternImpl
{
    class FourWheeler : IVehicle
    {
        public void Show()
        {
            Console.WriteLine("Inside four wheeler");
        }
    }
}
