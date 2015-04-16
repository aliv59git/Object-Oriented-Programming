
namespace Cosmetics.Products
{
    using System;
    using System.Text;
    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public abstract class Product : IProduct
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
            protected set
            {
                //if (value < 0)
                //{
                //    throw new ArgumentOutOfRangeException("Invlid price!");
                //}
                this.price = value;
            }
        }

        public GenderType Gender
        {
            get { return this.gender; }
            private set
            {
                //if (value != GenderType.Men || value != GenderType.Women || value != GenderType.Unisex)
                //{
                //    throw new ArgumentOutOfRangeException("Product gender must be Men, Women or Unisex!");
                //}
                this.gender = value;
            }
        }

        public virtual string Print() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("- {0} – {1}:", this.Brand, this.Name));
            sb.AppendLine(String.Format("  * Price: ${0}", this.Price));
            sb.AppendLine(String.Format("  * For gender: {0}", this.Gender));
            return sb.ToString();
        }
    }
}
