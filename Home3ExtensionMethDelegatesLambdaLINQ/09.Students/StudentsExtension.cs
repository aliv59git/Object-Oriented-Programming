using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Students
{
    public static class StudentsExtension
    {
        public static List<Student> StudentsInGroup2Ext(this List<Student> allstudents)
        {
            var result = (from st in allstudents
                         where st.GroupNumber == 2
                         orderby st.FirstName
                         select st).ToList();
            return result;     
                //students.FindAll(st => st.GroupNumber == 2).OrderBy(st => st.FirstName).ToList();
        }
    }
}
