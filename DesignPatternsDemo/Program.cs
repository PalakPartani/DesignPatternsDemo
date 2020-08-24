using System;
using DesignPatternsDemo.Behavioral;
using DesignPatternsDemo.Structural;
using DesignPatternsDemo.Creational;

namespace DesignPatternsDemo
{
    /// <summary>
    /// The execution starts from this class.
    /// </summary>
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("--------Design Pattern Demo---------");
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1 Creational Design Pattern");
                Console.WriteLine("2 Behavioral Design Pattern");
                Console.WriteLine("3 Structural Design Pattern");
                Console.WriteLine("0 To Exit");
                Console.WriteLine("------------------------------------");
               choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CreationalPatternDemo.Start();
                        break;
                    case 2:
                        BehavioralPatternDemo.Start();
                        break;
                    case 3:
                        StructuralPatternDemo.Start();
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Choice");
                        break;
                }

            } while (choice != 0);
        }
    }
}