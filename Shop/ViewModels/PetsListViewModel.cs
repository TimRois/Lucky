using Lucky.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky.ViewModels
{
    public class PetsListViewModel
    {

        public IEnumerable<Pet> allPets { get; set; }

        public string currCategory { get; set; }

    }
}
