using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClass
{
    class Order
    {        
        public static List<Product> orderlist = new List<Product>();
        public static void Choice()
        {
            Console.WriteLine($"Choose a product under number (\"0\" to stop)");
            do
            {
                bool not = true;
                string enter = Console.ReadLine();
                if ((int.TryParse(enter, out int number)) & (number > -1) & (number <= Shop.pricelist.Count))
                {
                    if (number == 0) { break; }
                    if(Shop.pricelist[number-1].quantity<=0)
                    {
                        Console.WriteLine($"{Shop.pricelist[number - 1].stuffname} are not present more !");
                        continue;
                    }
                    for(int i=0;i<orderlist.Count;i++)
                    {
                        if (orderlist[i].stuffname == Shop.pricelist[number-1].stuffname)
                        {
                            orderlist[i].quantity++;
                            Shop.pricelist[number - 1].quantity--;
                            not = false;
                        }                        
                    }
                    if(not)
                    {                       
                        orderlist.Add(new Product(Shop.pricelist[number - 1].stuffname, Shop.pricelist[number - 1].price, 1));                        
                        Shop.pricelist[number - 1].quantity--;
                    }
                }
                else
                {
                    Console.WriteLine("Try again.");
                    continue;
                }
            }
            while (true);            
        }
        public static decimal Totalprice()
        {
            decimal total = 0;
            for (int i = 0; i < orderlist.Count; i++) { total += orderlist[i].price * orderlist[i].quantity; }
            return total;
        }


    }
}
