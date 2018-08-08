using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeSampleRequirement.Models
{
    public class CriminalReportOrder : Order
    {

        public CriminalReportOrder()
        {
            this.OrderType = (int)OrderClassify.CriminalReport;
        }

    }
}