using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeSampleRequirement.Models
{
    public class ParamedOrder : Order
    {
        public ParamedOrder()
        {
            this.OrderType = (int) OrderClassify.Paramed;
        }
    }
}