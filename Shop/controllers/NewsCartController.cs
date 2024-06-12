using Microsoft.AspNetCore.Mvc;
using Lucky.Date;
using Lucky.Date.interfaces;
using Lucky.Date.Models;
using Lucky.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Lucky.controllers
{
    [Authorize(Roles = "user, admin")]
    public class NewsCartController : Controller
    {
        private readonly IAllNews _newsRep;
        public NewsCartController(IAllNews newsRep)
        {
            _newsRep = newsRep;       
        }


        [HttpGet]
        public ViewResult Index(int Id)
        {
            IEnumerable<News> news = new List<News>();

            news = _newsRep.News.Where(x => x.Id == Id);
            Console.WriteLine(news);
            var homePets = new NewsCartViewModel
            {
                getNews = news
            };
            return View(homePets);


        }

      
    }
}
