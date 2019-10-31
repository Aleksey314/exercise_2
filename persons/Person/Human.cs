using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Human
    {
        public string Name;
        public int Age;
        public virtual string Sex { get; set; }
        public string[] ListGirlNames = new string[] { "Mary", "Lisy", "Ann", "Nataly" };
        public string[] ListBoyNames = new string[] { "Bob", "Tom", "Sam", "Tony" };
        //public Human() { }
        //public Human(string name) { Name = name; }
        //public Human(string name,int age) : this(name) { Age = age; }
        public virtual void SetName()
        {
            Random rnd = new Random();
            switch(rnd.Next(0,2))
            {
                case 0:
                    Name = ListGirlNames[rnd.Next(0, ListGirlNames.Length)];
                    Sex = "W";
                    Age = rnd.Next(6, 15);
                    break;
                case 1:
                    Name = ListBoyNames[rnd.Next(0, ListBoyNames.Length)];
                    Sex = "M";
                    Age = rnd.Next(6, 15);
                    break;
                default:
                    Console.WriteLine("Something is wrong");
                    break;
            }
        }
        public virtual void ToDisplay()
        {
            Console.WriteLine($"Name is {Name} Age is {Age} Sex {Sex}");
        }
    }
}
