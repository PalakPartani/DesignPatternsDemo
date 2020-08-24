using System;
using System.Collections.Generic;
using System.Text;

namespace abstractFactoryDemo
{
    class Pigeon : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("pigeon");
        }
    }
}
