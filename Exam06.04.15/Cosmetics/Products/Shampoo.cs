﻿using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Shampoo : Product, IProduct, IShampoo
    {
        private UsageType usage;
        private uint milliliters;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public uint Milliliters
        {
            get { return this.milliliters; }
            private set { this.milliliters = value; }
        }
        public UsageType Usage
        {
            get { return this.usage; }
            private set { this.usage = value; }
        }

        public override string Print()
        {
            string result = String.Format("* Quantity: {0} ml ", this.Milliliters);
            result += String.Format("* Usage: EveryDay/Medical");
            

            - {product brand} – {product name}:
              * Price: ${product price}
              * For gender: {product gender}
              * Quantity: {product quantity} ml (when applicable)
              * Usage: EveryDay/Medical (when applicable)    
            return result;
        }



    }
}
