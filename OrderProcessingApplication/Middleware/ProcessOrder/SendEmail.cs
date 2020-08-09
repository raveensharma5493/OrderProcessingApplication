using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware
{
    public class SendEmail : BaseOrder
    {
        public override string ProcessOrder()
        {
            return MailToCustoomer();
                
        }
        public string MailToCustoomer()
        {
            //EMail logic should be written here 
            return "Email has been send to customer";
        }
    }
}
