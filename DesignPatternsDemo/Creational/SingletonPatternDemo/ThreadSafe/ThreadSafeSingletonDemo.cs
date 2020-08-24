using System;
using System.Collections.Generic;
using System.Text;

namespace threadsafedemo
{
    /// <summary>
    /// Singleton Pattern Demo
    /// </summary>
    /// 
    public class ThreadSafeSingltonDemo
    {
        public static void Start()
        {
            ThreadSafe threadSafeSingletonOne = ThreadSafe.GetInstance;
            ThreadSafe threadSafeSingletonTwo = ThreadSafe.GetInstance;

            threadSafeSingletonOne.PrintDetails("Hello In thread safe.");
            threadSafeSingletonTwo.PrintDetails("Hello in thread safe 2");
            Console.ReadLine();
        }
    }
}
