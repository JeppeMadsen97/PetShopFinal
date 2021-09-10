using System;
using System.Collections.Generic;
using System.Linq;
using PetShop.Core.IServices;
using PetShop.Core.Models;

namespace PetShop
{
    public class Menu
    {
        private IPetService _service;
        private IPetTypeService _serviceType;

        public Menu(IPetService service, IPetTypeService typeService)
        {
            _service = service;
            _serviceType = typeService;
        }

        public void Start()
        {
            StartLoop();
        }

        private void StartLoop()
        {
            int choice;
            while ((choice = GetMainMenuSelection()) != 0) 
            {
                if (choice == 1)
                {
                    CreatePet();
                } else if (choice == 2)
                {
                    ReadAll();
                } else if (choice == 3)
                {
                    DeletePet();
                } else if (choice == 4)
                {
                    UpdatePet();
                } else if (choice == 5)
                {
                    SearchByType();
                } else if (choice == 6)
                {
                    Show5cheapest();
                } 
                else if (choice == -1)
                {
                    TryAgain();
                }
            }
        }

        private void SearchByType()
        {
            Print(StringConstant.SearchByType);
            int chosenPetTypeId = int.Parse(Console.ReadLine());
            bool doesIdExist = DoesIdExist(chosenPetTypeId);
            if (!doesIdExist)
            {
                Print(StringConstant.IdNotFound);
            }
            else if (doesIdExist)
            {
                foreach (var pet in _service.ReadAll())
                {
                    if (chosenPetTypeId == pet.PetType.Id)
                    {
                        Print(pet.ToString());
                    }
                } 
            }
        }

        private bool DoesIdExist(int chosenPetTypeId)
        {
            bool occuranceFound = false;
            foreach (var petType in _serviceType.GetAllPetTypes())
            {
                if (chosenPetTypeId == petType.Id)
                {
                    occuranceFound = true;
                }
            }
            return occuranceFound;
        }

        private void UpdatePet()
        {
            Print(StringConstant.UpdateMessage);
            foreach (var pet in _service.ReadAll())
            {
                Print(pet.ToString());
            }

            int chosenID;
            while (int.TryParse(Console.ReadLine(), out chosenID))
            {
                foreach (var pet in _service.ReadAll())
                {
                    if (chosenID == pet.Id)
                    {
                        UpdatePetLogic(pet);
                    }
                }
            }
        }

        private void UpdatePetLogic(Pet petToUpdate)
        {
            PrintNewLine();
            Print(StringConstant.CreatePetMessage);
            Print(StringConstant.PetName);
            var petName = Console.ReadLine();
            Print(StringConstant.PetType);
            Print(StringConstant.PetType2);
            string petTypeId = Console.ReadLine();
            PetType newPetType = _serviceType.getById(int.Parse(petTypeId));
            petToUpdate.Name = petName;
            petToUpdate.PetType = newPetType;
            _service.UpdatePet(petToUpdate);
        }

        private void Show5cheapest()
        {
            
            foreach (var pet in _service.getCheapest())
            {
                Print(pet.ToString());
            }
        }

        private void DeletePet()
        {
            Print(StringConstant.DeleteMessage);
            foreach (var pet in _service.ReadAll())
            {
                Print(pet.ToString());
            }

            int chosenID;
            while (int.TryParse(Console.ReadLine(), out chosenID))
            {
                foreach (var pet in _service.ReadAll().ToList())
                {
                    if (chosenID == pet.Id)
                    {
                        _service.DeletePet(pet);
                    }
                }
            }
        }

        private void CreatePet()
        {
            PrintNewLine();
            Print(StringConstant.CreatePetMessage);
            Print(StringConstant.PetName);
            var petName = Console.ReadLine();
            Print(StringConstant.PetType);
            Print(StringConstant.PetType2);
            string petTypeId = Console.ReadLine();
            Print(StringConstant.PetPrice);
            double petPrice = double.Parse(Console.ReadLine());
            //Print
            //var petPrice = Console.ReadLine();

            var pet = new Pet
            {
                Name = petName,
                PetType = _serviceType.getById(int.Parse(petTypeId)),
                Price = petPrice
            };
            pet = _service.Create(pet);

        }

        private void ReadAll()
        {
            Print(StringConstant.AllPets);
            var pets = _service.ReadAll();
            foreach (var pet in pets)
            {
                Print(pet.ToString());
            }
        }

        private void TryAgain()
        {
            Print(StringConstant.ErrorInSelection);
        }

        private int GetMainMenuSelection()
        {
            ShowMainMenu();
            PrintNewLine();
            var selectionString = Console.ReadLine();
            int selection;
            if (int.TryParse(selectionString, out selection))
            {
                return selection;
            }
            return -1;
        }
        private void ShowMainMenu()
        {
            PrintNewLine();
            Print(StringConstant.Welcome);
            Print(StringConstant.SelectFromMenu);
            Print(StringConstant.CreateNewPet);
            Print(StringConstant.ShowAllPets);
            Print(StringConstant.DeletePet);
            Print(StringConstant.UpdatePet);
            Print(StringConstant.SearchForSomething);
            Print(StringConstant.ShowCheapest);
            Print(StringConstant.ExitTheMainMenu);
        }
        
        private void PrintNewLine()
        {
            Console.WriteLine();
        }

        private void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
}