using SoftwareAcademy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy.Models
{
    public class LocalCourse : Course, ILocalCourse, ICourse
    {
        public LocalCourse(string name, ITeacher teacher, string lab)
            :base (name, teacher)
        {
            this.Lab = lab;
        }

        private string lab;

        public string Lab
        {
            get { return this.lab; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The lab has name!");
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
                this.lab = value; 
            }
        }

        public override string ToString()
        {
            return String.Format("{0}; Lab={1}", base.ToString(), this.Lab);
        }

        
    }
}
