using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    public class Product : IProduct
    {
        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;
        public Product(string name, string brand, decimal price, GenderType gender)
         {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value.Length < 3 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Product name must be between 3 and 10 symbols long!");
                }
                this.name = value;
            }
        }

        public string Brand
        {
            get { return this.brand; }
            private set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Product brand must be between 2 and 10 symbols long!");
                }
                this.brand = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invlid price!");
                }
                this.price = value;
            }
        }

        public Common.GenderType Gender
        {
            get { return this.gender; }
            private set
            {
                if (value.ToString() != "Men" || value.ToString() != "Women" || value.ToString() != "Unisex")
                {
                    throw new ArgumentOutOfRangeException("Product brand must be between 2 and 10 symbols long!");
                }
                this.gender = value;
            }
        }

        public IProduct Cosmetics { get; private set; }

        public virtual string Print()
        {

            string result = string.Format("- {0} - {1}:\n", this.Brand, this.Name);
              result += String.Format("* Price: ${0}\n", this.Price);
              result += String.Format("* For gender: Men/Women/Unisex\n");
              if(this.GetType().Name == "Toothpaste")
              {
                  result += this.GetType().Name + "\n";
              }
            result += String.Format("- {0} – {1}:\n", this.Brand, this.Name);
            result += String.Format("* Price: ${0}\n", this.Price);
            result += String.Format("* For Gender: ${0}\n", this.Gender);
                  
            return result;
        }



    }
}
