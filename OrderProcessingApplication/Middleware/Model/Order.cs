using System;

namespace Middleware
{
    public class Order
    {   
        public string OrderType { get; set; }
        public virtual void Validation()
        {
            throw new Exception("not implemented");
        }
    }
    public class Customer
    {
        public int CustomerID { get; set; }
        public int CustomerName { get; set; }
        public int Email { get; set; }
        public int Address { get; set; }
    }
}
