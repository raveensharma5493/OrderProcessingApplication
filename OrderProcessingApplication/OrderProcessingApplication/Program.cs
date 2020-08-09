using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using FactoryOrder;
using OrderInterfaces;

namespace OrderProcessingApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            //considering OrderProcessingApplication as UI of project for input.
            string orderType = Console.ReadLine();
            // on basis of orderType factory class will return object type
            //on basis of object type, procesorder will be called and appropriate logic get executed 
            Console.WriteLine(FactoryClass.Create(orderType).ProcessOrder());
            Console.ReadKey();
        }

    }
}
