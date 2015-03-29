using System;

namespace _1.SchoolClasses
{
    public class Student : Person, IPerson
    {
        private int classNumber;

        public Student (string name, int classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get { return this.classNumber; }
            protected set
            {
                if((value <= 0) || (value > 12))
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.classNumber = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} has an unique class number {1}.", this.Name, this.ClassNumber);
        }

    }
}
