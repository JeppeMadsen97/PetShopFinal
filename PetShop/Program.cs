using System;
using PetShop.Core.IServices;
using PetShop.Domain.IRepositories;
using PetShop.Domain.Services;
using PetShop.Infrastructure.DataAccess;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {

            IPetRepository repo = new PetRepository();
            IPetService service = new PetService(repo);
            
            IPetTypeRepository typeRepo = new PetTypeRepository();
            IPetTypeService typeService = new PetTypeService(typeRepo);
            
            var menu = new Menu(service, typeService);
            menu.Start();
        }
        
    }
}