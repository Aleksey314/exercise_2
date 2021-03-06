﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Group<T> where T:IAnimal
    {
        public class Cross
        {
            public T dat { get; set; }
            public string listSign { get; set; }
            public Cross Dat { get; set; }
            public Cross(T dat)
            {
                this.dat = dat;
                Dat = null;
                listSign = null;
            }
        }
        public Cross Last;
        public Group()
        {
            Last = null;            
        }
        public void AddInGroup(T n,string ls)
        {
            if((n.ClassOfAnAnimal==ls)|(n.WayOfAFood==ls)|(ls=="All"))
            {
                Cross c = new Cross(n);
                c.Dat = Last;
                c.listSign = ls;
                Last = c;
            }            
        }        
        public void GetGroup()
        {
            Cross last = Last;            
            Console.WriteLine($"List of {Last.listSign}");
            while (last!=null)
            {
                T Fig = last.dat;
                Fig.PrintCardOfAnAnimal();                             
                last = last.Dat;
            }            
            Console.WriteLine($"It is all in list of {Last.listSign} \n");
        }        
    }
}
