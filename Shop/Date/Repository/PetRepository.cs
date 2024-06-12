using Microsoft.EntityFrameworkCore;
using Lucky.Date.interfaces;
using Lucky.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky.Date.Repository
{
    public class PetRepository : IAllPets
    {
        private readonly AppDbContent appDbContent;

        public PetRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<Pet> Pets => appDbContent.Pet.Include(c => c.Category);

        public Pet getObjectPet(int PetId) => appDbContent.Pet.FirstOrDefault(p => p.Id == PetId);

    }
}
