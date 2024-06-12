using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky.Date.Models
{
    public class Order
    {
        public int id { get; set; }
        public string dateOrd { get; set; }

        public string email { get; set; }

        public int petID { get; set; }
        public virtual Pet Pet { set; get; }



    }
}
