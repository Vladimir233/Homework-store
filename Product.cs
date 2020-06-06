using System;
using System.Collections.Generic;

namespace Store
{
    public class Product
    {
        public int code;
        public string name;
        public int price;
        public int quantity;
        private List<Reserve> reserves;
        private int freeBalance;
        public Product(string name)
        {
            this.name = name;
            price = 0;
            quantity = 0;
            freeBalance = 0;
        }
        public void SetQuantity (int quantity)
        {
            this.quantity += quantity;
        }
        public void Reserved (int quantity, int customerIndex)
        {
            if (this.quantity >= quantity)
            {
                this.quantity -= quantity;
                var reserv = new Reserve(customerIndex, quantity);
                reserves.Add(reserv);
            }
            else
            {

            }
        }
        public List<Product> GetReserv(int customerIndex)
        {
            var products = new List<Product>();
            foreach (var reserv in reserves)
            {
                if(reserv.customerIndex == customerIndex)
                {
                    products.Add(reserv.product);
                    reserves.Remove(reserv);
                }
            }
            return products;
        }
        public int GetfreeBalance()
        {
            return freeBalance = quantity - reserves.Count;
        }
    }
}
