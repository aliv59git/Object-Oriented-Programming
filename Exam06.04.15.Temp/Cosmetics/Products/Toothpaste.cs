
namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Toothpaste : Product, IProduct, IToothpaste
    {
        private readonly IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, Common.GenderType gender,  IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.ValidateIngredients(ingredients);

            this.ingredients = ingredients;
        }

        public string Ingredients
        {
            get { return string.Join(", ", this.ingredients); }
        }

        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Print());
            sb.AppendLine(String.Format(" * Ingredients: {0}", this.Ingredients));

            return sb.ToString().Trim();
        }

        private void ValidateIngredients(IList<string> ingredients)
        {
            if (this.ingredients.Any(ingr => ingr.Length < 4 || ingr.Length > 12))
            {
                throw new ArgumentOutOfRangeException("Each ingredient must be between 4 and 12 symbols long!");
            }
        }
    }
}
