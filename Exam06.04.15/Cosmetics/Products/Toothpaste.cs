using Cosmetics.Contracts;
using Cosmetics.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Toothpaste : Product, IProduct, IToothpaste
    {
        private IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, Common.GenderType gender,  IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.ingredients = new List<string>();
        }

        public string Ingredients { get; private set; }

        public override string Print()
        {
            return "* Ingredients: "+string.Join(", ", this.ingredients);
        }


    }
}
