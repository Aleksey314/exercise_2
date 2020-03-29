using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsListLibrary
{
    public class AnimalsData
    {
        static List<IAnimal> animals = new List<IAnimal>
        {
                new Birds("Eagle", "Predator", "Birds"),
                new Birds("Parrot", "Herbivore", "Birds"),
                new Reptile("Lizard", "Predator", "Reptile"),
                new Reptile("Turtle", "Herbivore", "Reptile"),
                new Mammal("Buffalo", "Herbivore", "Mammal"),
                new Mammal("Tiger", "Predator", "Mammal")
        };
        public static void GetTypeOfAnimal(string typeOfAnimal)
        {
            Console.WriteLine($"\nThe list of {typeOfAnimal}:");
            var selected = animals.Where(a => a.WayOfAFood == typeOfAnimal|a.ClassOfAnAnimal==typeOfAnimal);
            foreach (var p in selected)
            {
                Console.WriteLine(p.NameOfAnAnimal);
            }
        }
        public static void GetListAlphabetically()
        {
            Console.WriteLine($"\nThe list alphabetically:");
            var selected = animals.OrderBy(a => a.NameOfAnAnimal);
            foreach (var p in selected)
            {
                Console.WriteLine(p.NameOfAnAnimal);
            }
        }
    }

}
