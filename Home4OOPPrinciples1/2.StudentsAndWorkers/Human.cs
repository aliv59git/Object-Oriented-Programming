using System;
using System.Collections;


namespace _2.StudentsAndWorkers
{
    public abstract class Human: IComparable<Human>
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

        public virtual int CompareTo(Human other)
        {
            return this.FirstName.CompareTo(other.FirstName);
        }


    }
}
