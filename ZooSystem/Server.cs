using System.Collections.Generic;

namespace ZooSystem
{
    class Server
    {

        private static List<Animal> animals = new List<Animal>();
        private static List<Vet> vets = new List<Vet>();

        public static bool AdminAuth(string usrName, string passWrd)
        {
            return true;
        }

        public static bool VetAuth(string usrName, string passWrd)
        {
            return true;
        }

        public static void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public static void AddVet(Vet vet)
        {
            vets.Add(vet);
        }

        public static List<Vet> GetVets()
        {
            return vets;
        }

        public static List<Animal> GetAnimals()
        {
            return animals;
        }

    }
}
