using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeSampleRequirement.Models;
using CodeSampleRequirement.Data;

namespace CodeSampleRequirement.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private OrderData orderDB;

        public OrderRepository()
        {
            orderDB = OrderData.GetInstance();
        }

        public void AddService(int orderId, string serviceName)
        {
            orderDB.AddService(orderId, serviceName);
        }

        public void CancelOrder(int orderId)
        {
            orderDB.CancelOrder(orderId);
        }

        public List<Order> GetOrders()
        {
            return orderDB.GetOrders();
        }

        public void SendToBilling(int orderId)
        {
            orderDB.SendToBilling(orderId);
        }
    }
}