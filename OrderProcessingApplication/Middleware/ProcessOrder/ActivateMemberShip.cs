using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware
{
    public class ActivateMemberShip : BaseOrder
    {
        public override string ProcessOrder()
        {
            return MemberShipActivate();
        }
        public string MemberShipActivate()
        {
            //logic for activate customer membership
            return "Membership Activated";
            
        }
    }
}
