using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    static class Sale
    {
        public static SalesReceipt saleFromReserve(Customer customer, List<Product> products)
        {
            int cost = 0;
            var salesReceipt = new SalesReceipt();
            foreach (var product in products)
            {
                cost += product.price*product.quantity;
            }
            salesReceipt.price = cost;
            if (customer.balance >= cost)
            {
                foreach (var product in products)
                {
                    salesReceipt.products.Add(product);
                }
            }
            else
            {
                //TO-DO Achtung!!!
            }
            return salesReceipt;
        }
    }
}
