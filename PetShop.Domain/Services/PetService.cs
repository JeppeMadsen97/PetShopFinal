using System.Collections.Generic;
using System.Linq;
using PetShop.Core.IServices;
using PetShop.Core.Models;
using PetShop.Domain.IRepositories;

namespace PetShop.Domain.Services
{
    public class PetService : IPetService
    {
        private IPetRepository _repo;

        public PetService(IPetRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Pet> ReadAll()
        {
            return _repo.FindAll();
        }

        public Pet Create(Pet pet)
        {
            return _repo.Add(pet);
        }

        public void DeletePet(Pet pet)
        {
            _repo.Delete(pet);
        }

        public void UpdatePet(Pet petToUpdate)
        {
            _repo.UpdatePet(petToUpdate);
        }

        public IEnumerable<Pet> getCheapest()
        {
            var orderByResult = from pet in ReadAll()
                orderby pet.Price descending 
                select pet;
            return orderByResult.Take(5).OrderBy(pet => pet);
        }
    }
}