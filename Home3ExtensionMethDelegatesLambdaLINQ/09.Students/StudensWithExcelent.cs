using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Students
{

    public class StudensWithExcelent
    {
        public string FullName
        {
            get
            {
                return this.ToString();
            }
            set
            {
                this.FullName = value;
            }
        }
        public List<int> Marks { get; set; }

    }
}
