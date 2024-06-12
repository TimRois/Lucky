using Microsoft.EntityFrameworkCore;
using Lucky.Date.interfaces;
using Lucky.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky.Date.Repository
{
    public class NewsRepository : IAllNews
    {
        private readonly AppDbContent appDbContent;

        public NewsRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<News> News => appDbContent.News;
        public News getObjectNews(int NewsId) => appDbContent.News.FirstOrDefault(p => p.Id == NewsId);

    }
}
