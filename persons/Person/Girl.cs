using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Girl:Human
    {
        public string FavDressColour { get; set; }//Girl class property only
        public string[] ColoursList = new string[] { "green", "red", "yellow", "pink" };
        public override string Sex { get { return "W"; } }//Overridden property
        //public Girl() { }
        //public Girl(string name,int age) : base(name, age) { }
        public override void SetName()//Overridden method сompletely
        {            
            Random rnd = new Random();
            Name = ListGirlNames[rnd.Next(0, ListGirlNames.Length)];
            Age = rnd.Next(6, 15);
            FavDressColour = ColoursList[rnd.Next(0, ColoursList.Length)];
        }
        public override void ToDisplay()//Overridden method
        {
            base.ToDisplay();
            Console.WriteLine($"Favourite colour of dress is {FavDressColour}");
        }
    }
}
