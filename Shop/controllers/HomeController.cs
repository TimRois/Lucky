using Microsoft.AspNetCore.Mvc;
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
    //[Authorize(Roles = "user, admin")]
    public class HomeController : Controller
    {
        private readonly IAllNews _newsRep;
        public HomeController( IAllNews newsRep)
        {
          _newsRep = newsRep;
        }
        public ViewResult Index()
        {
            IEnumerable<News> news = new List<News>();
            news = _newsRep.News.OrderBy(i => i.Id);
            var homeNews = new HomeViewModel
            {
                allNews = news
            };
            return View(homeNews);
        }
    }
}
