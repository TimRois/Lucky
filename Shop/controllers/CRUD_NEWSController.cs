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
    public class CRUD_NEWSController : Controller
    {
        private readonly AppDbContent appDBContent;
        public CRUD_NEWSController(AppDbContent appDBContnent)
        {
            this.appDBContent = appDBContnent;
        }
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(News model)
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

            using (appDBContent)
            {
                 Console.WriteLine(model);
                 if ( model.shortDesc != null && model.Desc != null && model.img != null)
                 {
                    if (a < 1)
                        model.img = "/img/no_photo.jpg";
                    appDBContent.News.Add(model);
                     appDBContent.SaveChanges();
                     Console.WriteLine(model);
                     return RedirectToAction("Read");
                 }
                 else
                if( model.shortDesc == null)
                ModelState.AddModelError(""," Введите короткое описание");
                if (model.Desc == null)
                    ModelState.AddModelError("", " Введите полное описание");
                if (model.img == null)
                    ModelState.AddModelError("", " Введите путь для картинки");

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
                var data = appDBContent.News.ToList();
                return View(data);
            }
        }
        [HttpGet]
        public ActionResult Update(News news)
        {
            using (appDBContent)
            {
                var data = appDBContent.News.Where(x => x.Id == news.Id).SingleOrDefault();
                return View(data);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int Id, News model)
        {
            using (appDBContent)
            {
                var data = appDBContent.News.FirstOrDefault(x => x.Id == model.Id);
                if (data != null && model.shortDesc != null && model.Desc != null  && model.img != null)
                { 
                 
                    data.shortDesc = model.shortDesc;
                    data.Desc = model.Desc;
                    data.img = model.img;
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
            var data = appDBContent.News.Where(x => x.Id == id).SingleOrDefault();  
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult
        Delete(int id, News news)
        {
            using (appDBContent)
            {
                var data = appDBContent.News.FirstOrDefault(x => x.Id == news.Id);

                if (data != null)
                {
                    appDBContent.News.Remove(data);
                    appDBContent.SaveChanges();
                    return RedirectToAction("Read");
                }
                else
                    return View();
            }
        }
    }
}
