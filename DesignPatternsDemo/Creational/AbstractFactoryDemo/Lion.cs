using System;
using System.Collections.Generic;
using System.Text;

namespace abstractFactoryDemo
{
    class Lion : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Lion roar");
        }
    }
}
