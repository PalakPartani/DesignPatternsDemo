using System;

namespace DesignPatternsDemo.Behavioral_DesignPattern.ObserverPattern
{
   public class ObserverPatternDemo
    {
       public static void Start()
        {
            // Create IBM stock and attach investors

            Console.Clear();
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // Fluctuating prices will notify investors

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
            Console.ReadLine();
        }
    }
}