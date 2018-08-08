using CodeSampleRequirement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSampleRequirement.Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        void CancelOrder(int orderId);
        void AddService(int orderId, string serviceName);
        void SendToBilling(int orderId);
    }
}
