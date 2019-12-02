using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClass
{
    class Shop
    {
        public static decimal account=0;
        public static List<Product> pricelist = new List<Product>
        {
            new Product("TV",150.89M,3),
            new Product("Coffee maker",50.55M,5),
            new Product("Microwave",65.90M,7),
            new Product("Blender",10.55M,7),
            new Product("Food processor",43.40M,7),
            new Product("Phone",100.30M,7)
        };
        
    }
}
