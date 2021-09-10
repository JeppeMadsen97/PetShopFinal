using System.Collections.Generic;
using PetShop.Core.Models;

namespace PetShop.Core.IServices
{
    public interface IPetService
    {
        IEnumerable<Pet> ReadAll();
        Pet Create(Pet pet);
        void DeletePet(Pet pet);
        void UpdatePet(Pet petToUpdate);
        IEnumerable<Pet> getCheapest();
    }
}