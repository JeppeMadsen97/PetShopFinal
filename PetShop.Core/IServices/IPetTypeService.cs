using System.Collections.Generic;
using PetShop.Core.Models;

namespace PetShop.Core.IServices
{
    public interface IPetTypeService
    {
        public PetType getById(int id);

        public void AddPetType(PetType petType);
        List<PetType> GetAllPetTypes();
    }
}