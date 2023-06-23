using DecoreatorPattern.Component;
using DecoreatorPattern.ConcreateComponent;
using DecoreatorPattern.ConcreateDecoreator;
using DecoreatorPattern.Decoreator;
using System;

namespace DecoreatorPattern
{
    class Program
    {
        /// <summary>
        /// Defination of Decoreator Pattern
        /// The Decorator design pattern attaches additional responsibilities to an object dynamically. This pattern provide a flexible alternative to subclassing for extending functionality.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            ICar objCar = new EconomyCar();

            //Wrp EconomyCar instancw with BasicAccessories.   
            CarAccessoriesDecorator objAccessoriesDecorator = new BasicAccessories(objCar);

            //Wrap EconomyCar instance with AdvancedAccessories instance.   
            objAccessoriesDecorator = new AdvanceAccessories(objAccessoriesDecorator);

            Console.Write("Car Detials: " + objAccessoriesDecorator.GetDescription());
            Console.WriteLine("\n\n");
            Console.Write("Total Price: " + objAccessoriesDecorator.GetPrice());

            Console.Read();
        }
    }
}
