using System;
using System.Collections.Generic;


namespace ConsoleApplication1
{
    public class Cat
    {
        public string  Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            var objAsCat = obj as Cat; //кастваме обекта към котка
            if (objAsCat == null)
            {
                return false;
            }
            if (objAsCat.Name != this.Name)
            {
                return false;
            }
            if (this.Age != objAsCat.Age)
            {
                return false;
            }

            return true; // това е една имплементация, която ни казва как се сравняват два обекта. 
        }

        public static bool operator ==(Cat firstCat, Cat secondCat)
        {            
            return Cat.Equals(firstCat, secondCat);
        }

        public static bool operator !=(Cat firstCat, Cat secondCat)
        {
            return !Cat.Equals(firstCat, secondCat);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Age;
        }
        public override string ToString()
        {
            return this.Name + " Miau...";
        }



    }
}
