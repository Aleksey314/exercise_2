﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    interface IAnimal
    {
        string NameOfAnAnimal { get; set; }
        string WayOfAFood { get; set; }
        string ClassOfAnAnimal { get; set; }        
        void PrintCardOfAnAnimal();        
    }
}
