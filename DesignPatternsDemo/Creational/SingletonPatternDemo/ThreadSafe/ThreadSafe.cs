using System;

namespace threadsafedemo
{
   public class ThreadSafe
    {
        private static int counter = 0;
        private static readonly object Instancelock = new object();
        private ThreadSafe()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static ThreadSafe instance = null;

        public static ThreadSafe GetInstance
        {
            get
            {
                lock (Instancelock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafe();
                    }
                    return instance;
                }
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}