using Middleware;
using System;
using Unity;
using OrderInterfaces;

namespace FactoryOrder
{
    public static class FactoryClass
    {
        public static IOrderProcessing Create(string orderType)
        {
            //register all dependency in container
            //this code should be in some where else(either startup.cs or web.config)
            UnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IOrderProcessing, SendEmail>("Email");
            unityContainer.RegisterType<IOrderProcessing, PhysicalOrderProcess>("PhysicalOrder");
            unityContainer.RegisterType<IOrderProcessing, ActivateMemberShip>("Membership");

            //resolve dependency on basis of type of order coming from UI
            //and call ProcessOrder method where logic should be written as per order type
            BaseOrder orderobj = unityContainer.Resolve<SendEmail>(orderType);
            return orderobj;
        }
    }
}
