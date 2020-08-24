using System;

namespace threadunsafe
{
    public class ThreadUnsafeDemo
    {
        public static void Start()
        {
            Console.WriteLine("Hello World!");
            Singleton singletonObj = Singleton.GetInstance;
            singletonObj.PrintDetails("Hello");
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("goodbye");
            Console.ReadLine();
        }
    }
}