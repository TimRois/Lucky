using Microsoft.AspNetCore.Mvc;
using Lucky.Date;
using Lucky.Date.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.IO;

namespace Lucky.controllers
{
    [Authorize(Roles = "admin")]
    public class CRUDController : Controller
    {
        private readonly AppDbContent appDBContent;
        public CRUDController(AppDbContent appDBContnent)
        {
            this.appDBContent = appDBContnent;
        }
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(Pet model)
        {
            using (appDBContent)
            {
                int a = 0;
                string dirName = "E:\\Lucky\\Shop\\wwwroot\\img";
                if (Directory.Exists(dirName))
                {
                    string[] files = Directory.GetFiles(dirName);
                    foreach (string s in files)
                    {
                        string result = s.Remove(0, 26);
                        if (result == model.img)
                            a++;
                    }
                }

                Console.WriteLine(model);
                 if ( model.name != null && model.vaccinations != null && model.breed != null && model.shortDesc != null && model.img != null  && model.categoryID != 0)
                 {

                    if (a < 1)
                    model.img = "/img/no_photo.jpg";
                    appDBContent.Pet.Add(model);
                    appDBContent.SaveChanges();
                     Console.WriteLine(model);
                     return RedirectToAction("Read");
                 }
                 else
                if( model.name==null)
                ModelState.AddModelError(""," Введите имя");
                if (model.vaccinations == null)
                    ModelState.AddModelError("", " Введите есть ли прививки");
                if (model.breed == null)
                    ModelState.AddModelError("", " Введите породу");
                if (model.shortDesc == null)
                    ModelState.AddModelError("", " Введите описание");
                if (model.img == null)
                    ModelState.AddModelError("", " Введите путь для картинки");
                //if (a<1)
                //    ModelState.AddModelError("", " Такой картинки нет, введите корректный путь");
                if (model.categoryID == 0)
                    ModelState.AddModelError("", " Введите категорию");
            }
            return View();
        }
        public IActionResult Error()
        {
            ViewBag.Message = "Данные заполнены неверно";
            return View();
        }
        [HttpGet]
        public ActionResult Read()
        {
            using (appDBContent)
            {
                var data = appDBContent.Pet.ToList();
                return View(data);
            }
        }
        [HttpGet]
        public ActionResult Update(Pet pet)
        {
            using (appDBContent)
            {
                var data = appDBContent.Pet.Where(x => x.Id == pet.Id).SingleOrDefault();
                return View(data);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int CourseId, Pet model)
        {
            using (appDBContent)
            {
                var data = appDBContent.Pet.FirstOrDefault(x => x.Id == model.Id);
                if (data != null && model.name != null && model.vaccinations != null && model.breed != null && model.shortDesc != null && model.img != null && model.categoryID != 0)
                { 
                    data.name = model.name;
                    data.shortDesc = model.shortDesc;
                    data.img = model.img;
                    data.vaccinations = model.vaccinations;
                    data.breed = model.breed;
                    data.categoryID = model.categoryID;
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
            var data = appDBContent.Pet.Where(x => x.Id == id).SingleOrDefault();  
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult
        Delete(int id, Pet pet)
        {
            using (appDBContent)
            {
                var data = appDBContent.Pet.FirstOrDefault(x => x.Id == pet.Id);

                if (data != null)
                {
                    appDBContent.Pet.Remove(data);
                    appDBContent.SaveChanges();
                    return RedirectToAction("Read");
                }
                else
                    return View();
            }
        }
    }
}
