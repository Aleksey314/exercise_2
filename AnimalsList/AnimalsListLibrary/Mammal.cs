﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsListLibrary
{
    class Mammal:IAnimal
    {
        public string NameOfAnAnimal { get; set; }
        public string WayOfAFood { get; set; }
        public string ClassOfAnAnimal { get; set; }
        public Mammal(string NameOfAnAnimal, string WayOfAFood, string ClassOfAnAnimal)
        {
            this.NameOfAnAnimal = NameOfAnAnimal;
            this.WayOfAFood = WayOfAFood;
            this.ClassOfAnAnimal = ClassOfAnAnimal;
        }
    }
}
