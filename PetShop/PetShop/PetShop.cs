using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
    public class PetShop
    {
        private Pet[] pets;


        public PetShop(int limit)
        {
            pets = new Pet[limit];
        }

        public Pet SellPet(int petIndex)
        {
            var chosenPet = pets[petIndex];
            
            for (int i = petIndex; i < pets.Length-1; i++)
            {
                pets[i] = pets[i + 1];
            }

            pets[pets.Length - 1] = null;
            return chosenPet;
        }


        public void AddPet(Pet newPet)
        {

        }




        public void GeneratePets()
        {
            Random rnd = new Random();



            for (int i = 0; i < pets.Length; i++)
            {

                pets[i] = new Pet
                {
                    Name = $"Pet{i}",
                    Age = rnd.Next(1, 100),
                    MaxAge = 100,
                    Price = (decimal)rnd.NextDouble() * 200,
                    Quantity = rnd.Next(10, 200),
                    Kind = (AnimalKind)rnd.Next(0, 5)


                };

            } 
        }


        public void DisplayPets()
        {
            for (int i = 0; i < pets.Length; i++)
            {
                if (pets[i]==null)
                {
                    Console.WriteLine("Null");
                }
                
                Console.WriteLine(pets[i]);

            }
        }

       





    }
}
