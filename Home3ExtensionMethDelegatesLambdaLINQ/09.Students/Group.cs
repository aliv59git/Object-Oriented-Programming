using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Students
{
    public class Group
    {
        private int groupNumber;
        private string departmentName;
        public string DepartmentName 
        {
            get
            {
                return this.departmentName;
            }
            set { this.departmentName = value; }
        }
        public int GroupNumber 
        {
            get
            {
                return this.groupNumber;
            }
            set { this.groupNumber = value; }
        }

        public Group()
        {
        }

        public Group(int groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }
    }
}
