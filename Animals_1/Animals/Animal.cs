﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animal:IAnimal
    {
        public string NameOfAnAnimal { get; set; }        
        public string WayOfAFood { get; set; }        
        public string ClassOfAnAnimal { get; set; }        
        public Animal (string NameOfAnAnimal,string WayOfAFood,string ClassOfAnAnimal)
        {
            this.NameOfAnAnimal = NameOfAnAnimal;
            this.WayOfAFood = WayOfAFood;
            this.ClassOfAnAnimal = ClassOfAnAnimal;                       
        }
        public virtual void PrintCardOfAnAnimal()
        {            
            Console.WriteLine($"-{NameOfAnAnimal} is a  {WayOfAFood}");
        }

    }
}
