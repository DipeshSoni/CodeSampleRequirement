using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeSampleRequirement.Models
{
    public class CreditCheckOrder : Order
    {
        public CreditCheckOrder()
        {
            this.OrderType = (int)OrderClassify.CreditCheck;
        }
    }
}