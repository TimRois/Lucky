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
    public class PetCartController : Controller
    {
        private readonly IAllPets _petRep;
        private readonly AppDbContent appDBContent;
        public PetCartController(IAllPets petRep, AppDbContent appDBContnent)
        {
            _petRep = petRep;
            this.appDBContent = appDBContnent;
        }


        [HttpGet]
        public ViewResult Index(int Id)
        {
            IEnumerable<Pet> pets = new List<Pet>();

            pets = _petRep.Pets.Where(x => x.Id == Id);
            Console.WriteLine(pets);
            var homePets = new PetCartViewModel
            {
                getPets = pets
            };
            return View(homePets);


        }

        public ActionResult Complete()
        {
            ViewBag.Message = "Спасибо за обращение, с вами свяжутся";
            return View();
        }


        [HttpGet]
        public ActionResult create(int Id)
        {

            DateTime date1 = DateTime.Now;
            string dateOrd2 = date1.ToString();
                var email2 = User.Identity.Name;
                var pet = Id;
                appDBContent.Order.Add(new Order { dateOrd = dateOrd2, email = email2,petID = pet });
                appDBContent.SaveChanges();

            return RedirectToAction("Complete");
        }
    }
}
