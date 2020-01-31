﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Mammal:Animal
    {
        public Mammal(string NameOfAnAnimal, string WayOfAFood, string ClassOfAnAnimal) : base(NameOfAnAnimal, WayOfAFood, ClassOfAnAnimal) { }       
        public override void PrintCardOfAnAnimal()
        {            
            Console.WriteLine($"-{NameOfAnAnimal} is a {ClassOfAnAnimal} , {WayOfAFood}");
        }
    }
}
