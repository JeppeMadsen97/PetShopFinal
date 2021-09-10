using System.Collections.Generic;
using PetShop.Core.Models;

namespace PetShop.Domain.IRepositories
{
    public interface IPetRepository
    {
        List<Pet> FindAll();
        Pet Add(Pet pet);
        void Delete(Pet pet);
        void UpdatePet(Pet petToUpdate);
    }
}