using System.ComponentModel;

namespace PetShop
{
    public class StringConstant
    {
        public static string Welcome = "Welcome to the pet Store";
        public static string SelectFromMenu = "Please select one of the options below";
        public static string CreateNewPet = "1 = Create new pet";
        public static string ShowAllPets = "2 = Show all pets available";
        public static string AllPets = "Here are all of our pets";
        public const string SearchForSomething = "5 = search pets by type";
        public const string ErrorInSelection = "Please select a number between 1-3";
        public const string ExitTheMainMenu = "Select 0 to exit app";
        public const string CreatePetMessage = "Creating Pet";
        public const string PetName = "Please enter [Name of Animal]";
        public const string PetType = "Please enter [1-3]";
        public const string PetType2 = "1 - dog " +
                                       "2 - cat " +
                                       "3 - hamster";
        public const string PetPrice = "Please enter [Price of pet]";
        public const string PetColour = "Please enter [Colour of pet]";
        public static string DeletePet = "3 = Delete a pet";
        public static string DeleteMessage = "Here is a list of pets that can be deleted";
        public static string UpdateMessage = "Here is a list of pets that can be updated";
        public static string UpdatePet = "4 = update a pet";


        public static string SearchByType = "Enter Id 1-3 of pet type to search for";
        public static string IdNotFound = "The ID was not found. Try Again";
        public static string ShowCheapest = "6 = Show 5 cheapest pets";
    }
}