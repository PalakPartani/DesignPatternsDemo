using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternImpl
{
    public interface IFactory
    {
        public IVehicle CreateObject(string className);
    }
}
