using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public abstract class Furniture :IFurniture
    {

public string Model
{
	get { throw new NotImplementedException(); }
}

public string Material
{
	get { throw new NotImplementedException(); }
}

public decimal Price
{
	  get 
	{ 
		throw new NotImplementedException(); 
	}
	  set 
	{ 
		throw new NotImplementedException(); 
	}
}

public decimal Height
{
	get { throw new NotImplementedException(); }
}
}
            set
            {
                if (string.IsNullOrEmpty(value))
                {

                }
            }
        }

        public string Material
        {
            get { throw new NotImplementedException(); }
        }

        public decimal Price
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal Height
        {
            get { throw new NotImplementedException(); }
        }
    }
}
