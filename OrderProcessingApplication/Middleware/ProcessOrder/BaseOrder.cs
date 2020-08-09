using System;
using System.Collections.Generic;
using System.Text;
using OrderInterfaces;

namespace Middleware
{
    public class BaseOrder : IOrderProcessing
    {
        public string OrderName { get; set; }
        public int Amount { get; set; }
        public virtual string ProcessOrder()
        {
            throw new NotImplementedException();
        }
    }
}
