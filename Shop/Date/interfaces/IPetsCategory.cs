﻿using Lucky.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky.Date.interfaces
{
    public interface IPetsCategory
    {

        IEnumerable<Category> AllCategories { get; }
    }
}
