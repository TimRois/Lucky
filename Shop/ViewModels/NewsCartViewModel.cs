using Lucky.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky.ViewModels
{
    public class NewsCartViewModel
    {
        public IEnumerable<News> getNews { get; set; }
    }
}
