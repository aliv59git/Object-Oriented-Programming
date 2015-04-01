using System;
using System.Collections.Generic;
using System.Linq;


namespace CTS
{
    public class Cat : IAnimal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            var objAsCat = obj as Cat;
            if (objAsCat == null)
            {
                return false;
            }
            if (this.Name != objAsCat.Name)
            {
                return false;
            }
            if (this.Age != objAsCat.Age)
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(Cat firstCat, Cat secondCat)
        {
            return Cat.Equals(firstCat, secondCat);

        }
        public static bool operator !=(Cat firstCat, Cat secondCat)
        {
            return Cat.Equals(firstCat, secondCat);

        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Age;
        }
        public override string ToString()
        {
            return this.Name + " Miauu...";
        }

    }
}
