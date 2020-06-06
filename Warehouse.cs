using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class Warehouse
    {
        public int index;
        public string name;
        public List<Product> products;
        public void AddNewProduct(string name)
        {
            var product = new Product(name)
            {
                code = products.Count + 100001
            };
            products.Add(product);
        }
        public bool AddProducts(Product product, int quantity)
        {
            foreach (var prod in products)
            {
                if (prod.code == product.code)
                {
                    prod.SetQuantity(quantity);
                    return true;
                }
            }
            return false;
        }
        public bool RemoveProduct(Product product)
        {
            foreach (var prod in products)
            {
                if (prod.code == product.code)
                {
                    if(prod.quantity == 0)
                    {
                        products.Remove(prod);
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }
    }
}
