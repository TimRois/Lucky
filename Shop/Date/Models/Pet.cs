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
    public class Pet
    {
 
        public int Id { get; set; }

     
        public string name { get; set; }

        public string shortDesc { get; set; }

        public string img { get; set; }

        public string vaccinations { get; set; }

        public string breed { get; set; }

        public int categoryID { get; set; }
        public virtual Category Category { set; get; }

    }
}
