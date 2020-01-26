using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalList.SetAll();
            AnimalList.SetGroup();
            AnimalList.mammalList.GetGroup();
            AnimalList.birdsList.GetGroup();
            AnimalList.reptileList.GetGroup();
            AnimalList.herbivoreList.GetGroup();
            AnimalList.predatorList.GetGroup();
        }
    }
}
