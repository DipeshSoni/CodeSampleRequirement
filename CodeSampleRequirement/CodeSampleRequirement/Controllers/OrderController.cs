using CodeSampleRequirement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeSampleRequirement.Controllers
{
    public class OrderController : Controller
    {
        private OrderService orderService;

        public OrderController()
        {
            orderService = new OrderService();
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetOrders()
        {
            return Json(orderService.GetOrders(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Cancel(int orderId)
        {
            ViewBag.OrderId = orderId;
            return View();
        }
        
        public ActionResult AddService(int orderId, string serviceName)
        {
            orderService.AddService(orderId, serviceName);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int orderId)
        {
            ViewBag.OrderId = orderId;
            return View("EditOrderService");
        }
        
        public ActionResult SendToBilling(int orderId)
        {
            ViewBag.OrderId = orderId;
            return View();
        }
    }
}