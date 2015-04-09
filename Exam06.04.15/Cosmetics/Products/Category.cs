using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Category : ICategory
    {
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
                if (value.Length < 2 || value.Length > 15)
                {
                    throw new ArgumentOutOfRangeException("Category name must be between 2 and 15 symbols long!");
                }
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
            var orderedCosmeticsCategory = from pr in cosmeticsCategory
                                           .OrderBy(pr => pr.Brand)
                                           .ThenByDescending(pr => pr.Price)
                                           .Select(pr => pr);
                                           



            string result = string.Format("{0} category – {1} products/product in total", this.Name, cosmeticsCategory.Count);
            result += this.ToString();
            


            return result;
        }


    }
}
