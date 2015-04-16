namespace Cosmetics.Products
{
    using System;
    using System.Text;
    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Shampoo : Product, IProduct, IShampoo
    {
        private UsageType usage;
        private uint milliliters;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
            this.Price *= this.milliliters;
        }

        public uint Milliliters
        {
            get { return this.milliliters; }
            private set { this.milliliters = value; }
        }
        public UsageType Usage
        {
            get { return this.usage; }
            private set
            {
                if (value != UsageType.EveryDay || value != UsageType.Medical)
                {
                    throw new ArgumentOutOfRangeException("Invalid usage!");
                }
                this.usage = value;
            }
        }

        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Print());
            sb.AppendLine(String.Format(" * Quantity: {0} ml", this.Milliliters));
            sb.AppendLine(String.Format(" * Usage: {0}", this.Usage));
            return sb.ToString();
        }
    }
}
