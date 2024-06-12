using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Lucky.Date.Models
{
    public class News
    {
 
        public int Id { get; set; }

        public string shortDesc { get; set; }
        public string Desc { get; set; }

        public string img { get; set; }

    }
}
