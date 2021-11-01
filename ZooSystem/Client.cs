using System;
using System.Collections.Generic;

namespace ZooSystem
{
    class Client
    {
        static void Main(string[] args)
        {
            Char usr = ' ';

            Console.WriteLine("Welcome to the Zoo Animal System\n");

            Console.WriteLine("Please indicate if you are a Admin (A) or a Veternarian (V). \n");
            Console.WriteLine("If you wish to exit the program please press the 'X' key.");

            while (usr != 'x' || usr != 'X')
            {


                usr = Convert.ToChar(Console.ReadLine());

                if (usr.Equals('v') || usr.Equals('V'))
                {

                    while (usr != 'x' || usr != 'X')
                    {
                        ListAnimals();
                        Console.WriteLine("To add a Animal press 'A', to exit press 'X'\n");
                        usr = Convert.ToChar(Console.ReadLine());

                        if (usr == 'A' || usr == 'a')
                        {
                            string name;
                            string type;
                            int age;
                            Console.WriteLine("Please enter the animal's name.\n");
                            name = Console.ReadLine();
                            Console.WriteLine("Please enter the type of animal. \n");
                            type = Console.ReadLine();
                            Console.WriteLine("Please enter the age of the animal.\n");
                            age = Convert.ToInt32(Console.ReadLine());
                            AddAnimal(name, type, age);
                        }
                        else if (usr == 'x' || usr == 'X')
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please press the appropriate key for your selection.\n");
                        }
                    }
                    return;
                }
                else if (usr.Equals('a') || usr.Equals('A'))
                {
                    while (usr != 'x' || usr != 'X')
                    {
                        ListVets();
                        Console.WriteLine("To add a Vet press 'A', to exit press 'X'\n");
                        usr = Convert.ToChar(Console.ReadLine());

                        if (usr == 'A' || usr == 'a')
                        {
                            string name;
                            Console.WriteLine("Please enter the vet's name.\n");
                            name = Console.ReadLine();
                            AddVet(name);

                        }
                        else if (usr == 'x' || usr == 'X')
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please press the appropriate key for your selection.\n");
                        }
                    }
                    return;
                }
                else
                {
                    if (usr == 'X' || usr == 'x')
                    {
                        Console.WriteLine("Exiting program........\n");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Please press the appropriate key for your selection.");
                    }
                }
            }
            return;
        }

        private static bool AdminAuth(string usrName, string passWrd)
        {
            if (Server.AdminAuth(usrName, passWrd))
                return true;
            else
                return false;
        }

        private static bool VetAuth(string usrName, string passWrd)
        {
            if (Server.VetAuth(usrName, passWrd))
                return true;
            else
                return false;
        }

        public static void AddAnimal(string name, string type, int age)
        {
            Animal newAnimal = new Animal();
            string nme;
            string tpe;
            int ag;
            newAnimal.SetName(name);
            newAnimal.SetAnimalType(type);
            newAnimal.SetAge(age);
            Server.AddAnimal(newAnimal);
        }
        public static void AddVet(string name)
        {
            Vet newVet = new Vet();

            newVet.SetName(name);
            Server.AddVet(newVet);
        }

        public static void ListVets()
        {
            List<Vet> vets = Server.GetVets();
            if (vets.Count == 0)
            {
                Console.WriteLine(String.Format("   |{0,-10}|\n", "Name"));
                Console.WriteLine("1: ");
            }
            else
            {
                Console.WriteLine(String.Format("   |{0,-10}|\n", "Name"));
                int count = 1;
                foreach (Vet v in vets)
                {
                    string tmp = String.Format("{0}: {1,-10}  \n", count, v.GetName());
                    Console.WriteLine(tmp);
                    count++;
                }
            }

        }
        public static void ListAnimals()
        {
            List<Animal> animals = Server.GetAnimals();
            if (animals.Count == 0)
            {
                Console.WriteLine(String.Format("   |{0,-10}|{1,-10}|{2,-10}|\n", "Name", "Type", "Age"));
                Console.WriteLine("1: ");
            }
            else
            {
                Console.WriteLine(String.Format("   |{0,-10}|{1,-10}|{2,-10}|\n", "Name", "Type", "Age"));
                int count = 1;
                foreach (Animal a in animals)
                {
                    string tmp = String.Format("{0}: {1,-10} {2,-10} {3,-10}\n", count, a.GetName(), a.GetAnimalType(), a.GetAge());
                    Console.WriteLine(tmp);
                    count++;
                }
            }

        }

    }
}
