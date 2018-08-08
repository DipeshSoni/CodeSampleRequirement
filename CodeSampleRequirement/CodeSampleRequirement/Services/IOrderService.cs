using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSampleRequirement.Models;

namespace CodeSampleRequirement.Services
{
    public interface IOrderService
    {
        List<Order> GetOrders();
        void CancelOrder(int orderId);
        void AddService(int orderId, string serviceName);
        void SendToBilling(int orderId);
    }
}
