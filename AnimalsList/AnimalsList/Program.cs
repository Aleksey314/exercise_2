using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalsListLibrary;

namespace AnimalsList
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalsData.GetTypeOfAnimal("Herbivore");
            AnimalsData.GetTypeOfAnimal("Predator");
            AnimalsData.GetTypeOfAnimal("Birds");
            AnimalsData.GetTypeOfAnimal("Reptile");
            AnimalsData.GetTypeOfAnimal("Mammal");
            AnimalsData.GetListAlphabetically();
        }
    }
}
