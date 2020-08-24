using System;

namespace abstractFactoryDemo
{
   public class AbstractFactory
    {
       public static void Start()
        {
            Console.WriteLine("Hello World!");
            IAnimal animal = null;
            AnimalFactory animalFactory = null;
            string speakSound = null;

            Console.WriteLine("--------------------------");
            // Create Land Factory object by passing the factory type as Land
            animalFactory = AnimalFactory.CreateAnimalFactory("Land");
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            Console.WriteLine();

            // Get Lion Animal object by passing the animal type as Lion
            animal = animalFactory.GetAnimal("Lion");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            animal.Speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();


            // Create the Sea Factory object by passing the factory type as Sea
            animalFactory = AnimalFactory.CreateAnimalFactory("Air");
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            Console.WriteLine();
            // Get Octopus Animal object by passing the animal type as Octopus
            animal = animalFactory.GetAnimal("Pigeon");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            animal.Speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
