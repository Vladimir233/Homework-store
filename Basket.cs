using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class Basket
    {
        public List<Product> basket;
        public void AddToBasket(List<Product> products)
        {
            foreach (var product in products)
            {
                basket.Add(product);
            }
        }
        public void RemoveFromBaket(Product removeProduct)
        {
            foreach (var product in basket)
            {
                if(product.code == removeProduct.code)
                {
                    basket.Remove(product);
                }
            }
        }
    }
}
