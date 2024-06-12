using Lucky.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky.Date.interfaces
{
    public interface IAllPets
    {
        IEnumerable<Pet> Pets { get; }
        Pet getObjectPet(int PetId);
    }
}
