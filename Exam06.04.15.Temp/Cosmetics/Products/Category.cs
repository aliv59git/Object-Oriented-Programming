
namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Cosmetics.Common;
    using Cosmetics.Contracts;


    public class Category : ICategory
    {
        public const int MinSymbols = 2;
        public const int MaxSymbols = 15;

        private string name;
        private IList<IProduct> products;

        public Category(string name)
        {
            this.Name = name;
            this.products = new List<IProduct>();
        }

        public string Name
        {
            get { return this.name; }
            private set 
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "The name can not be null!");
                Validator.CheckIfStringLengthIsValid(value, MaxSymbols, MinSymbols, String.Format(GlobalErrorMessages.InvalidStringLength, "Category name", MinSymbols, MaxSymbols));
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, String.Format(GlobalErrorMessages.ObjectCannotBeNull, "Cosmetics to add to category"));
            this.products.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, String.Format(GlobalErrorMessages.ObjectCannotBeNull, "Cosmetics to remove from category"));
            if (!products.Contains(cosmetics))
            {
                throw new InvalidOperationException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }

            this.products.Remove(cosmetics);
        }

        public string Print()
        {
            var stringFirstLine = String.Format("{0} category – {1} {2} in total", this.Name, this.products.Count, this.products.Count != 1 ? "products" : "product");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(stringFirstLine);
            var orderedCosmeticsCategory = this.products
                                .OrderBy(pr => pr.Brand)
                                .ThenByDescending(pr => pr.Price);

            foreach (var item in orderedCosmeticsCategory)
	            {
                    sb.AppendLine(item.Print());
	            }
            return sb.ToString().Trim();
        }
    }
}
