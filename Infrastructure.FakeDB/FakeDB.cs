using System.Collections.Generic;
using PetShop.Core.Models;

namespace Infrastructure.FakeDB
{
    public class FakeDB
    {
        private static List<Pet> _FakeDBPet = new List<Pet>();
        private static List<PetType> _FakeDBPetType = new List<PetType>();
        private static int _id = 1;

        public List<Pet> GetAllPets()
        {
            return _FakeDBPet;
        }

        public List<PetType> GetAllPetTypes()
        {
            return _FakeDBPetType;
        }

        public Pet AddPet(Pet pet)
        {
            pet.Id = _id++;
            _FakeDBPet.Add(pet);
            return pet;
        }
    }
}