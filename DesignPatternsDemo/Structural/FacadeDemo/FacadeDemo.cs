using System;

namespace StructuralFacadeDemo
{
    public class FacadeDemo
    {
        public static void Start()
        {
            Console.WriteLine("Hello World!");
            Order order = new Order();
            order.PlaceOrder();
            Console.ReadLine();

        }
    }
}