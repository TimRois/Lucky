using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky.Date.Models
{
    public class Category
    {

        public int id { get; set; }
        public string category_name { get; set; }
        public string desc { get; set; }
        public List<Pet> Pets { get; set; }





    }
}
