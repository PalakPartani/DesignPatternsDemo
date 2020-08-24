using System;
using FactoryPatternImpl;
using threadunsafe;
using abstractFactoryDemo;

namespace DesignPatternsDemo.Creational
{
   public class CreationalPatternDemo
    {
        public static void Start()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("------Creational Pattern Demo-------");
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1 To See Factory Design Pattern");
                Console.WriteLine("2 To See Singleton Design Pattern");
                Console.WriteLine("3 To See Abstract factory Design Pattern");
                Console.WriteLine("0 To Go Back");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------------------------");
                switch (choice)
                {
                    case 1:
                        FactoryDemo.Start();
                        break;
                    case 2:
                        SingletonPattern.Start();
                        break;
                    case 3:
                        AbstractFactory.Start();
                        break;
                    case 4: break;
                    default:
                        Console.WriteLine("Please Enter Valid Choice");
                        break;
                }

            } while (choice != 0);
        }
    }
}