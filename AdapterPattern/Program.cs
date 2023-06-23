using System;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Definition 
            ///Adapter pattern acts as a bridge between two incompatible interfaces. This pattern involves a single class called adapter which is responsible for communication between two independent or incompatible interfaces.
            ///Real world example : For Example: A card reader acts as an adapter between a memory card and a laptop. You plugins the memory card into card reader and card reader into the laptop so that memory card can be read via laptop
            ///

            ////
            ///  ITraget - Target interface
            /// Employee Adapter-Adapter Class
            /// HR System - Adaptee Class

            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }
    }
}
