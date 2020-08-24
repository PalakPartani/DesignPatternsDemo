
namespace threadunsafe
{
        using System;
        using threadsafedemo;

        class SingletonPattern
        {
            public static void Start()
            {
                int choice;
                do
                {
                    Console.Clear();
                    Console.WriteLine("-------Singleton Pattern Demo-------");
                    Console.WriteLine("Enter Your Choice");
                    Console.WriteLine("1 To See Thread Unsafe Singleton Design Pattern");
                    Console.WriteLine("2 To See Thread safe Singleton Design Pattern");
                    Console.WriteLine("0 To Go Back");
                    Console.WriteLine("------------------------------------");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            ThreadUnsafeDemo.Start();
                            break;
                        case 2:
                            ThreadSafeSingltonDemo.Start();
                            break;
                        case 3:
                           break;
                        default:
                            Console.WriteLine("Please Enter Valid Choice");
                            break;
                    }

                } while (choice != 0);
            }
        }
    }