using System;
using System.Collections.Generic;
using Infrastructure.FakeDB;
using PetShop.Core.Models;
using PetShop.Domain.IRepositories;

namespace PetShop.Infrastructure.DataAccess
{
    public class PetRepository : IPetRepository
    {
        private List<Pet> _petRepo = new List<Pet>();
        private int id = 1;

        public PetRepository()
        {
            if (_petRepo.Count <= 0)
            {
                PopulateDB();
            }
        }

        private void PopulateDB()
        {
            Add(new Pet
                {Name = "Hurry", Birthdate = DateTime.Now, PetType = new PetType {Id = 1, Name = "McQuire"}, Price = 432.0});
            Add(new Pet
                {Name = "Burry", Birthdate = DateTime.Now, PetType = new PetType {Id = 1, Name = "McQuire"}, Price = 5432.0});
            Add(new Pet
                {Name = "Sheesh", Birthdate = DateTime.Now, PetType = new PetType {Id = 1, Name = "McQuire"}, Price = 123.0});
            Add(new Pet
                {Name = "Murry", Birthdate = DateTime.Now, PetType = new PetType {Id = 1, Name = "McQuire"}, Price = 7654.0});
            Add(new Pet
                {Name = "Curry", Birthdate = DateTime.Now, PetType = new PetType {Id = 1, Name = "McQuire"}, Price = 543.0});
            Add(new Pet
                {Name = "Theesh", Birthdate = DateTime.Now, PetType = new PetType {Id = 1, Name = "McQuire"}, Price = 987.0});
        }

        public List<Pet> FindAll()
        {
            return _petRepo;
        }

        public Pet Add(Pet pet)
        {
            pet.Id = id++;
            _petRepo.Add(pet);
            return pet;
        }

        public void Delete(Pet pet)
        {
            _petRepo.Remove(pet);
        }

        public void UpdatePet(Pet petToUpdate)
        {
            foreach (var pet in _petRepo)
            {
                if (petToUpdate.Id == pet.Id)
                {
                    pet.Name = petToUpdate.Name;
                    pet.PetType = petToUpdate.PetType;
                }
            }
        }
    }
}