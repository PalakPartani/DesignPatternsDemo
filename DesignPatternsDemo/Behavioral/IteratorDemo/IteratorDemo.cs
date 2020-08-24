using System;

namespace BehavoiuralIterator
{
   public class IteratorDemo
    {
        public static void Start()
        {
            {
                Console.WriteLine("Hello World!");
                ConcreteCollection collection = new ConcreteCollection();
                collection.AddEmployee(new Employee("Palakk", 16));
                collection.AddEmployee(new Employee("Vishal", 30));
                collection.AddEmployee(new Employee("Tavisha", 12));
                collection.AddEmployee(new Employee("Ekansh", 18));

                // Create iterator
                Iterator iterator = collection.CreateIterator();
                Console.WriteLine("Iterating over collection:");

                for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
                {
                    Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
                }
                Console.ReadLine();
            }
        }
    }
}