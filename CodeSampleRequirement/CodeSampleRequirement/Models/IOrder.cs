using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSampleRequirement.Models
{
    public interface IOrder
    {
        int OrderId { get; set; }
        string CustomerName { get; set; }
        long AccountNumber { get; set; }
        List<string> Services { get; set; }
    }
}
