using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClass
{
    class Product
    {
        public decimal price;
        public string stuffname;
        public int quantity { get; set; }
        public Product (string stuffname,decimal price,int quantity)
        {
            this.price = price;            
            this.stuffname = stuffname;
            this.quantity = quantity;
        }
        public static void PrintProductList(List<Product> products)
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {products[i].stuffname} - {products[i].price} BYN ({products[i].quantity} p)");
            }
        }
    }
}
