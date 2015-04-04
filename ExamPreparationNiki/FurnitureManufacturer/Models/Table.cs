using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class Table : Furniture, ITable
    {
        public decimal Length
        {
            get { throw new NotImplementedException(); }
        }

        public decimal Width
        {
            get { throw new NotImplementedException(); }
        }

        public decimal Area
        {
            get { throw new NotImplementedException(); }
        }
    }
}
