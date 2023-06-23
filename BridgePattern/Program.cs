using BridgePattern.ConcreateImplementation;
using BridgePattern.RedefineAbstration;
using System;

namespace BridgePattern
{
    class Program
    {


        /// <summary>
        /// Defination: Decouples an abstraction from its implementation so that the two can vary independently
        /// </summary>
        /// <param name="args"></param>
        /// In the Bridge Pattern there are two layer one is Abstraction Layer and other is implementation layer. If I do any changes in abstration layer, then it  won't effected implementation Layer. Similary If I made any change in  implementation, then it won't effected abstration layer
        /// 
        /// Real world Example
        /// Suppose, you want to turn on the TV or turn off the TV, then what you can do here is, you can use the Remote Control to turn On/Off the TV. The implementation will be done by the original TV implementer. So, in this case, Samsung TV or Sony TV will implement the turn On or turn Off functionality. So, the abstraction will use one of the implementers to turn on or turn off the TV.
        /// Suppose, later you want to add a new implementation then you can do this in the implementation layer. For example, you can add new TV (for example Panasonic TV) in the implementation layer which will not affect the Abstraction layer. Like that, you can also add a new Panasonic TV remote in the abstraction layer without affecting the implementation layer. So, this is one of the best examples of bridge design patterns


        static void Main(string[] args)
        {
            SonyRemoteControl sonyRemoteControl = new SonyRemoteControl(new SonyLedTv());
            sonyRemoteControl.TrunOnTv();
            sonyRemoteControl.SetChannel(101);
            sonyRemoteControl.TrunOnTv();

            Console.WriteLine();
            SamsungRemoteControl samsungRemoteControl = new SamsungRemoteControl(new SamsungLedTv());
            samsungRemoteControl.TrunOnTv();
            samsungRemoteControl.SetChannel(202);
            samsungRemoteControl.TrunOnTv();

            Console.ReadKey();
        }
    }
}
