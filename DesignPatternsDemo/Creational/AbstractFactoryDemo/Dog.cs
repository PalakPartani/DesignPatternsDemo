using System;
using System.Collections.Generic;
using System.Text;

namespace abstractFactoryDemo
{
    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("dog bark");
        }
    }
}
