using System;
using BehavoiuralIterator;
using BehaviourStateDemo;
using DesignPatternsDemo.Behavioral_DesignPattern.ObserverPattern;

namespace DesignPatternsDemo.Behavioral
{
   public class BehavioralPatternDemo
    {
        public static void Start()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("------Behavioral Pattern Demo-------");
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1 To See State Design Pattern");
                Console.WriteLine("2 To See Iterator Design Pattern");
                Console.WriteLine("3 To See Observer Design Pattern");
                Console.WriteLine("0 To Go Back");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------------------------");
                switch (choice)
                {
                    case 1:
                        StateDemo.Start();
                        break;
                    case 2:
                        IteratorDemo.Start();
                        break;
                    case 3:
                        ObserverPatternDemo.Start();
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