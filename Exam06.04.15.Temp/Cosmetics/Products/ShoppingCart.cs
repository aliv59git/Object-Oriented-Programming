
namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using Cosmetics.Contracts;
    using System.Linq;

    class ShoppingCart : IShoppingCart
    {
        private IList<IProduct> products;

        public ShoppingCart()
        {
            this.products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("Product can not be null!");
            }
            this.products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {

            if (product == null)
            {
                throw new ArgumentNullException("Product can not be null!");
            }
            this.products.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            //bool containProduct = false;
            //if (this.products.Contains(product))
            //{
            //    containProduct = true;
            //}
            return this.products.Contains(product);
        }

        public decimal TotalPrice()
        {
            decimal result = 0.0m;
            foreach (var item in this.products)
            {
                result += item.Price;
            }
            return result;

            //return this.products.Sum(pr => pr.Price);

        }
    }
}
