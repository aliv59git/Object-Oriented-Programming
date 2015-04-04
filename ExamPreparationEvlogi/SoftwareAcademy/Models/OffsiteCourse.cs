using SoftwareAcademy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy.Models
{
    public class OffsiteCourse : Course, IOffsiteCourse, ICourse
    {
        private string town;

        public string Town
        {
            get { return this.town; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The town has name!");
                }
                //if (value.Length < 2 || value.Length > 50)
                //{
                //    throw new ArgumentOutOfRangeException();
                //}
                //foreach (var ch in value)
                //{
                //    if (!Course.IsAllowed(ch))
                //    {
                //        throw new ArgumentException("Invalid name");
                //    }
                //}

                this.town = value; 
            }
        }
        

        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.Town = town;
        }

        public override string ToString()
        {
            return string.Format("{0}; Town={1}", base.ToString(), this.Town);
        }


    }
}
