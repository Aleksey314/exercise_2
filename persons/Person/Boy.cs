using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Boy:Human
    {
        public string FavSport { get; set; }
        public string[] SportList = new string[] { "Football", "Hockey", "Struggle", "Races" };
        public override string Sex { get { return "M"; } }
        //public Boy() { }
        //public Boy(string name,int age) : base(name, age) { }
        public override void SetName()
        {            
            Random rnd = new Random();
            Name = ListBoyNames[rnd.Next(0, ListBoyNames.Length)];
            Age = rnd.Next(6, 15);
            FavSport = SportList[rnd.Next(0, SportList.Length)];
        }
        public override void ToDisplay()
        {
            base.ToDisplay();
            Console.WriteLine($"Favourite sport is {FavSport}");
        }
    }
}
