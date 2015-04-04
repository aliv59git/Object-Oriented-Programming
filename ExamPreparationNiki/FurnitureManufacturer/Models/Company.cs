using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    class Company : ICompany
    {




        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public string RegistrationNumber
        {
            get { throw new NotImplementedException(); }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { throw new NotImplementedException(); }
        }

        public void Add(IFurniture furniture)
        {
            throw new NotImplementedException();
        }

        public void Remove(IFurniture furniture)
        {
            throw new NotImplementedException();
        }

        public IFurniture Find(string model)
        {
            throw new NotImplementedException();
        }

        public string Catalog()
        {
            throw new NotImplementedException();
        }
    }
}
