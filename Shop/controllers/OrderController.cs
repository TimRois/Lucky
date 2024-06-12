using Microsoft.AspNetCore.Mvc;
using Lucky.Date.interfaces;
using Lucky.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Lucky.controllers
{
    [Authorize(Roles = "user, admin")]
    public class OrderController : Controller
    {
        //private readonly IAllOrders allOrders;      

        //public OrderController(IAllOrders allOrders)
        //{
        //    this.allOrders = allOrders;
        //}

        //public IActionResult checkout()
        //{

        //    return View();
        //}

        //[HttpPost]
        //public IActionResult checkout(Order order)
        //{
        //    shopCart.listShopItems = shopCart.getShopItem();
        //    if (shopCart.listShopItems.Count == 0)
        //    {
        //        ModelState.AddModelError("", " В корзине ничего нет");
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        allOrders.createOrder(order);
        //        return RedirectToAction("Complete");
        //    }
        //    return View(order);
        //}

        //public IActionResult Complete()
        //{

        //    ViewBag.Message = "Спасибо за обращение, с вами свяжутся";
        //    return View();
        //}

    }
}
