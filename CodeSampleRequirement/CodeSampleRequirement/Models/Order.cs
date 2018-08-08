using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeSampleRequirement.Models
{
    public enum OrderClassify
    {
        Paramed = 0, CreditCheck, CriminalReport
    }

    public abstract class Order : IOrder
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public long AccountNumber { get; set; }
        public List<string> Services { get; set; }
        public int OrderType { get; set; }

        public override string ToString()
        {
            return $"Order ID: {OrderId} \n" +
                   $"AccountNumber: {AccountNumber}" +
                   $"CustomerName: {CustomerName}" +
                   $"Services Count: {Services.Count}";
        }
    }
}