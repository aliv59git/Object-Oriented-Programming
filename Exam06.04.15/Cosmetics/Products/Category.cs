using Cosmetics.Contracts;
using Cosmetics.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Category : ICategory
    {
        public const int MinSymbols = 2;
        public const int MaxSymbols = 15;

        private string name;
        private ICollection<IProduct> cosmeticsCategory;

        public Category(string name)
        {
            this.Name = name;
            this.cosmeticsCategory = new List<IProduct>();
        }

        public string Name
        {
            get { return this.name; }
            private set 
            {
                Validator.CheckIfStringLengthIsValid(value, MaxSymbols, MinSymbols, String.Format("Category name must be between {0} and {1} symbols long!", MinSymbols, MaxSymbols));
                //if (value.Length < 2 || value.Length > 15)
                //{
                //    throw new ArgumentOutOfRangeException(String.Format("Category name must be between {0} and {1} symbols long!", MinSymbols, MaxSymbosl));
                //}
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            if (cosmetics != null)
            {
                this.cosmeticsCategory.Add(cosmetics);
            }
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (cosmeticsCategory.Contains(cosmetics))
            {
                this.cosmeticsCategory.Remove(cosmetics);
            }
            else
            {
                string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name);
            }
        }

        public string Print()
        {
            var orderedCosmeticsCategory = cosmeticsCategory
                                .OrderBy(pr => pr.Brand)
                                .ThenByDescending(pr => pr.Price)
                                .Select(pr => pr);
            StringBuilder sb = new StringBuilder();
            if (cosmeticsCategory.Count == 1)
            {
                sb.AppendLine(String.Format("{0} category – {1} product in total", this.Name, this.cosmeticsCategory.Count));
            }
            else if (cosmeticsCategory.Count > 1)
            {
                sb.AppendLine(String.Format("{0} category – {1} products in total", this.Name, this.cosmeticsCategory.Count));
            }
            else
            {
                throw new ArgumentException("The cosmeticsCategoy is empty!");
            }
            foreach (var item in cosmeticsCategory)
	            {
		            item.Print();
	            }
            return sb.ToString();
        }
    }
}
