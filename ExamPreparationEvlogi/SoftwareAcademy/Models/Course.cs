using SoftwareAcademy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy.Models
{
    public abstract class Course : ICourse
    {
        private string name;

        private ICollection<string> topics;

        public Course(string name, ITeacher teacher)
            :this()
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
        }
        public Course()
        {
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name must not be null");
                }
                //foreach (var ch in value)
                //{
                //    if (!IsAllowed(ch))
                //    {
                //        throw new ArgumentException("Invalid Name");
                //    }
                //}
                this.name = value;
            }
        }

        public ITeacher Teacher { get; set; }

        public void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            string result = string.Format("{0}: Name={1}", this.GetType().Name, this.Name);
            if(this.Teacher != null)
            {
                result += string.Format("; Teacher={0}", this.Teacher.Name);
            }
            if(this.topics.Count > 0)
            {
                result += string.Format("; Topics=[{0}]", string.Join(", ", this.topics));
            }

            return result;

            //(course type): Name=(course name); Teacher=(teacher name); Topics=[(course topics – comma separated)]; 
            //Lab=(lab name – when applicable); Town=(town name – when applicable);
        }


        public static bool IsAllowed(char ch)
        {
            bool isAllowed = char.IsLetterOrDigit(ch) || ch==' ' || ch == '-';
            return isAllowed;
        }

    }
}
