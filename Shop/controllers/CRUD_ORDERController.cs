using Microsoft.AspNetCore.Mvc;
using Lucky.Date;
using Lucky.Date.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Lucky.controllers
{
    [Authorize(Roles = "admin")]
    public class CRUD_ORDERController : Controller
    {
        private readonly AppDbContent appDBContent;

        public CRUD_ORDERController(AppDbContent appDBContnent)
        {
            this.appDBContent = appDBContnent;
        }

        [HttpGet]
        public ActionResult Read()
        {
            using (appDBContent)
            {
                var data = appDBContent.Order.ToList();
                return View(data);
            }
        }

        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(Order model)
        {
            int a = 0;
            using (appDBContent)
            {

                Pet find = appDBContent.Pet.Find(model.petID);
                if(find !=null)
                {
                    a++;
                }

                Console.WriteLine(model);
                if (model.dateOrd != null && model.email != null && model.petID > 0 && a>0)
                {
                    appDBContent.Order.Add(model);
                    appDBContent.SaveChanges();
                    Console.WriteLine(model);
                    return RedirectToAction("Read");
                }
                else
               if (model.dateOrd == null)
                    ModelState.AddModelError("", " Введите дату");
                if (model.email == null)
                    ModelState.AddModelError("", " Введите email");
                if (model.petID <0)
                    ModelState.AddModelError("", " Введите айди питомца");
                if (a < 1)
                    ModelState.AddModelError("", " Такого питомца нет.");
            }
            return View();
        }
        public IActionResult Error()
        {
            ViewBag.Message = "Данные заполнены неверно";
            return View();
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            using (appDBContent)
            {
                var data = appDBContent.Order.Where(x => x.id == id).SingleOrDefault();
                return View(data);
            }
        }
         [HttpPost]
         [ValidateAntiForgeryToken]
        public ActionResult Update(int id, Order model)
        {
            using (appDBContent)
            {
                var data = appDBContent.Order.FirstOrDefault(x => x.id == id);
                if (data != null && model.dateOrd != null && model.email != null && model.petID >0)
                {
                    data.dateOrd = model.dateOrd;
                    data.email = model.email;
                    data.petID = model.petID;
                    appDBContent.SaveChanges();
                    return RedirectToAction("Read");
                }
                else
                {
                    return RedirectToAction("Error");
                }
            }
        }
        public ActionResult Delete(int id)
        {
            var data = appDBContent.Order.Where(x => x.id == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult
        Delete(int id, Order order)
        {
            Console.WriteLine(id);
            using (appDBContent)
            {
                var data = appDBContent.Order.FirstOrDefault(x => x.id == id);

                if (data != null)
                {
                    appDBContent.Order.Remove(data);
                    appDBContent.SaveChanges();
                    return RedirectToAction("Read");
                }
                else
                    return View();
            }
        }
    }
}
