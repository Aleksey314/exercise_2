using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class AnimalList
    {
        public static List<Animal> animalList=new List<Animal>();
        public static Group<Animal> mammalList=new Group<Animal>();
        public static Group<Animal> reptileList=new Group<Animal>();
        public static Group<Animal> birdsList=new Group<Animal>();
        public static Group<Animal> herbivoreList=new Group<Animal>();
        public static Group<Animal> predatorList=new Group<Animal>();        
        public static void SetAll()
        {            
            animalList.Add(new Animal("Lizard", "Predator", "Reptile"));
            animalList.Add(new Animal("Buffalo", "Herbivore", "Mammal"));
            animalList.Add(new Animal("Eagle", "Predator", "Birds"));
            animalList.Add(new Animal("Parrot", "Herbivore", "Birds"));
            animalList.Add(new Animal("Tiger", "Predator", "Mammal"));
            animalList.Add(new Animal("Turtle", "Herbivore", "Reptile"));
        }
        
        public static void SetGroup()
        {
            foreach (Animal i in animalList)
            {                
                switch (i.ClassOfAnAnimal)
                {
                    case "Mammal":  mammalList.AddInGroup(i,i.ClassOfAnAnimal); break;
                    case "Birds":  birdsList.AddInGroup(i,i.ClassOfAnAnimal); break;
                    case "Reptile":  reptileList.AddInGroup(i,i.ClassOfAnAnimal); break;
                }                
                switch (i.WayOfAFood)
                {
                    case "Predator":  predatorList.AddInGroup(i,i.WayOfAFood);break;
                    case "Herbivore":  herbivoreList.AddInGroup(i,i.WayOfAFood);break;
                }
            }
        }
    }
}
