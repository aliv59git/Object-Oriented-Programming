using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    class ShoppingCart : IShoppingCart
    {
        private ICollection<Product> shoppingCart;
        public ShoppingCart SoppingCart { get; private set; }
        public ShoppingCart()
        {
            this.shoppingCart = new List<Product>();
        }

        public void AddProduct(IProduct product)
        {
            this.shoppingCart.Add(product as Product);
        }

        public void RemoveProduct(IProduct product)
        {
            if (this.shoppingCart.Contains(product))
            {
                this.shoppingCart.Remove(product as Product);
            }
        }

        public bool ContainsProduct(IProduct product)
        {
            bool containProduct = false;
            if (this.shoppingCart.Contains(product))
            {
                containProduct = true;
            }

            return containProduct;
        }

        public decimal TotalPrice()
        {
            decimal result = 0.0m;
            foreach (var item in this.shoppingCart)
            {
                result += item.Price;
            }

            return result;
        }
    }
}
