using System.Collections.Generic;
using Infrastructure.FakeDB;
using PetShop.Core.Models;
using PetShop.Domain.IRepositories;

namespace PetShop.Infrastructure.DataAccess
{
    public class PetTypeRepository : IPetTypeRepository
    {
        private List<PetType> _petTypeRepo = new List<PetType>();
        private int id = 1;

        
        
        public PetTypeRepository()
        {
            AddPetType(new PetType{Name = "Dog"});
            AddPetType(new PetType{Name = "Cat"});
            AddPetType(new PetType{Name = "Hamster"});
        }
        
        
        public PetType getById(int id)
        {
           return _petTypeRepo.Find(type => type.Id == id);
        }

        public void AddPetType(PetType petType)
        {
            petType.Id = id++;
            _petTypeRepo.Add(petType);
        }

        public List<PetType> GetAllTypes()
        {
            return _petTypeRepo;
        }
    }
}