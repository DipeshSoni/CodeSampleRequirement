using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeSampleRequirement.Models;
using CodeSampleRequirement.Repositories;

namespace CodeSampleRequirement.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository orderRepo;

        public OrderService()
        {
            orderRepo = new OrderRepository();
        }

        public List<Order> GetOrders()
        {
            return orderRepo.GetOrders();
        }

        public void CancelOrder(int orderId)
        {
            orderRepo.CancelOrder(orderId);
        }

        public void AddService(int orderId, string serviceName)
        {
            orderRepo.AddService(orderId, serviceName);
        }

        public void SendToBilling(int orderId)
        {
            orderRepo.SendToBilling(orderId);
        }
    }
}