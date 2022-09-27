using System;

namespace PetShop
{
    class Program
    {
        static void Main()
        {
            PetShop petShop = new PetShop(20);

            petShop.GeneratePets();

            petShop.DisplayPets();

            petShop.SellPet(2);

            petShop.DisplayPets();



        }
    }
}
