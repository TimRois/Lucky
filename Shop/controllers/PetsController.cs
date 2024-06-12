using Microsoft.AspNetCore.Mvc;
using Lucky.Date;
using Lucky.Date.interfaces;
using Lucky.Date.Models;
using Lucky.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Lucky.controllers
{
    //[Authorize(Roles = "user, admin")]
    public class PetsController : Controller
    {

        private readonly IAllPets _allPets;
        private readonly IPetsCategory _allCategories;

        public PetsController(IAllPets iAllPets, IPetsCategory iPetCat)
        {
            _allPets = iAllPets;
            _allCategories = iPetCat;
        }

        [Route("Pets/List")]
        [Route("Pets/List/{category}")]

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Pet> pets = new List<Pet>();
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                pets = _allPets.Pets.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("category1", category, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(category);
                    pets = _allPets.Pets.Where(i => i.Category.category_name.Equals("Dogs")).OrderBy(i => i.Id);
                    currCategory = _category;
                    Console.WriteLine(category);
                }
                else if (string.Equals("category2", category, StringComparison.OrdinalIgnoreCase))
                {
                    pets = _allPets.Pets.Where(i => i.Category.category_name.Equals("Cats")).OrderBy(i => i.Id);
                    currCategory = _category;
                }


            }

            var carObj = new PetsListViewModel
            {
                allPets = pets,
                currCategory = currCategory
            };
            ViewBag.Title = "Pets page";
            return View(carObj);
        }



    }
}
