using Microsoft.AspNetCore.Mvc;
using Lucky.Date;
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
    [Authorize(Roles = "user, admin")]
    public class SearchController : Controller
    {

        private readonly IAllPets _petRep;

        public SearchController(IAllPets petRep)
        {
            _petRep = petRep;

        }

        [HttpPost]
        public ViewResult Index(string name)
        {

            IEnumerable<Pet> pets = new List<Pet>();                    
            pets = _petRep.Pets.Where(x => x.name == name);
            var homePets = new SearchViewModel
            {
                getPets = pets
        };
            return View(homePets);

           
        }

    }
}
