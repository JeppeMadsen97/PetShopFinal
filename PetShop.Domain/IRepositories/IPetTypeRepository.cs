using System.Collections.Generic;
using PetShop.Core.Models;

namespace PetShop.Domain.IRepositories
{
    public interface IPetTypeRepository
    {
        public PetType getById(int id);

        public void AddPetType(PetType petType);

        List<PetType> GetAllTypes();
    }
}