using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClass
{
    class Customer
    {
        public string name;
        public decimal account;
        public List<Product> stufflist = new List<Product>();
        public Customer(string name,decimal account)
        {
            this.name = name;
            this.account = account;
        }
        bool possibility;
        public bool Possibility
        {            
            get
            {
                if (Order.Totalprice() <= account) { possibility = true; }
                else { possibility = false; }
                return possibility;
            }
        }
        public void Purchase()
        {
            if(Possibility)
            {
                for(int i = 0; i < Order.orderlist.Count; i++) { stufflist.Add(Order.orderlist[i]); }
                account -= Order.Totalprice();
                Shop.account += Order.Totalprice();
                Order.orderlist.Clear();
                Console.WriteLine($"Purchase is successful");
            }
            else
            {
                Console.WriteLine($"There is not enough money for the {name} account.\nPurchase is rejected.");
                foreach(Product i in Order.orderlist)
                    foreach(Product j in Shop.pricelist)
                        if (i.stuffname == j.stuffname) { j.quantity += i.quantity; }
                Order.orderlist.Clear();
            }
        }
    }
}
