using System;
using StructuralFacadeDemo;
using StructureDecoratorDemo;
using StructuralAdapterDemo;

namespace DesignPatternsDemo.Structural
{
    public class StructuralPatternDemo
    {
        public static void Start()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("------Structural Pattern Demo-------");
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1 To See Adapter Design Pattern");
                Console.WriteLine("2 To See Decorator Design Pattern");
                Console.WriteLine("3 To See Facade Design Pattern");
                Console.WriteLine("0 To Go Back");
                Console.WriteLine("------------------------------------");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FacadeDemo.Start();
                        break;
                    case 2:
                        DecoratorDemo.Start();
                        break;
                    case 3:
                        AdapterDemo.Start();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Choice");
                        break;
                }

            } while (choice != 0);
        }
    }
}