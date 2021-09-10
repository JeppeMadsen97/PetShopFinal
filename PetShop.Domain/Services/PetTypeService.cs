using System.Collections.Generic;
using PetShop.Core.IServices;
using PetShop.Core.Models;
using PetShop.Domain.IRepositories;

namespace PetShop.Domain.Services
{
    public class PetTypeService : IPetTypeService
    {
        private IPetTypeRepository _typeRepo;


        public PetTypeService(IPetTypeRepository repo)
        {
            _typeRepo = repo;
        }
        
        public PetType getById(int id)
        {
             return _typeRepo.getById(id);
        }

        public void AddPetType(PetType petType)
        {
            _typeRepo.AddPetType(petType);
        }

        public List<PetType> GetAllPetTypes()
        {
            return _typeRepo.GetAllTypes();
        }
    }
}