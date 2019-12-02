using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Product.PrintProductList(Shop.pricelist);
            Customer customer1 = new Customer("Pit", 200M);
            Order.Choice();
            Console.WriteLine($"\n{customer1.name} order:");
            Product.PrintProductList(Order.orderlist);
            Console.WriteLine($"\ntotal {Order.Totalprice()} BYN");            
            customer1.Purchase();
            Console.WriteLine($"\n{customer1.name} purchases:");
            Product.PrintProductList(customer1.stufflist);
            Console.WriteLine($"\n{customer1.name} account {customer1.account} BYN");
            Console.WriteLine($"\nShop account: {Shop.account} BYN");
            Product.PrintProductList(Shop.pricelist);
        }
    }
}
