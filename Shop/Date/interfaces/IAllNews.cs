using Lucky.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky.Date.interfaces
{
    public interface IAllNews
    {
        IEnumerable<News> News { get; }
        News getObjectNews(int NewsId);
    }
}
