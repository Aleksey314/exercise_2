using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest
{
    public class AnimalList
    {
        public static Group<Animal> animalList=new Group<Animal>();
        public static Group<Mammal> mammalList=new Group<Mammal>();
        public static Group<Reptile> reptileList=new Group<Reptile>();
        public static Group<Birds> birdsList=new Group<Birds>();
        public static Group<Animal> herbivoreList=new Group<Animal>();
        public static Group<Animal> predatorList=new Group<Animal>();        
        public static void SetAll()
        {            
            animalList.AddInGroup(new Animal("Lizard", "Predator", "Reptile"), "All");
            animalList.AddInGroup(new Animal("Buffalo", "Herbivore", "Mammal"), "All");
            animalList.AddInGroup(new Animal("Eagle", "Predator", "Birds"), "All");
            animalList.AddInGroup(new Animal("Parrot", "Herbivore", "Birds"), "All");
            animalList.AddInGroup(new Animal("Tiger", "Predator", "Mammal"), "All");
            animalList.AddInGroup(new Animal("Turtle", "Herbivore", "Reptile"), "All");
        }
        
        public static void SetGroup()
        {
            Group<Animal>.Cross last = animalList.Last;
            while(last!=null)
            {                
                mammalList.AddInGroup(new Mammal(last.dat.NameOfAnAnimal,last.dat.WayOfAFood,last.dat.ClassOfAnAnimal), "Mammal");
                reptileList.AddInGroup(new Reptile(last.dat.NameOfAnAnimal,last.dat.WayOfAFood,last.dat.ClassOfAnAnimal), "Reptile");
                birdsList.AddInGroup(new Birds(last.dat.NameOfAnAnimal,last.dat.WayOfAFood,last.dat.ClassOfAnAnimal), "Birds");
                herbivoreList.AddInGroup(last.dat, "Herbivore");
                predatorList.AddInGroup(last.dat, "Predator");
                last = last.Dat;
            }
            
        }
    }
}
