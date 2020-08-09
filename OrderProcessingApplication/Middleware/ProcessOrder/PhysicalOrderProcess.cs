using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware
{
    public class PhysicalOrderProcess : BaseOrder
    {
        public override string ProcessOrder()
        {
            return GenertePackingSlip();
        }
        public string GenertePackingSlip()
        {
            return "packing slip generated";
        }
    }
}
