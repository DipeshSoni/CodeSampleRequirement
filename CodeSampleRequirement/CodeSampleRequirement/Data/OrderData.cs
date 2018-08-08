using CodeSampleRequirement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeSampleRequirement.Data
{
    public class OrderData
    {
        private static OrderData instance = null;
        private List<Order> orders = new List<Order>();

        private OrderData()
        {
            this.orders = new List<Order>
            {
                new ParamedOrder
                {
                    OrderId = 100,
                    AccountNumber = -1,
                    CustomerName = "Test Customer #1",
                    Services = new List<string> { "Serv1", "Serv3" }
                },
                new CreditCheckOrder
                {
                    OrderId = 101,
                    AccountNumber = -1,
                    CustomerName = "Test Customer #2",
                    Services = new List<string> { "Serv1", "Serv2", "Serv3" }
                },
                new CriminalReportOrder
                {
                    OrderId = 102,
                    AccountNumber = -1,
                    CustomerName = "Test Customer #3",
                    Services = new List<string> { "Serv1" }
                }
            };
        }

        public static OrderData GetInstance()
        {
            if(instance == null)
            {
                instance = new OrderData();
            }
            return instance;
        }

        public void AddService(int orderId, string service)
        {
            var order = orders.Find(o => o.OrderId == orderId);
            if(order != null)
            {
                order.Services.Add(service);
            }
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public void CancelOrder(int orderId)
        {
            var order = orders.Find(o => o.OrderId == orderId);
            if (order != null)
            {
                // cancel the order
            }
        }

        public List<Order> GetOrders()
        {
            return orders;
        }

        public void SendToBilling(int orderId)
        {
            var order = orders.Find(o => o.OrderId == orderId);
            if (order != null)
            {
                // send to billing
            }
        }
    }
}