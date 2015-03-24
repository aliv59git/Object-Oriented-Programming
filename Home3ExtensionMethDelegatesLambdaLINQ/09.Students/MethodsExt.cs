using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Students
{
    public static class MethodsExt
    {
        public static List<Student> OrderByNames(this List<Student> allStudents)
        {
            var result = (from st in allStudents
                          where st.GroupNumber == 2
                          orderby st.FirstName
                          select st).ToList();

            return result;
        }

        public static List<Student> OrderByNames1(this List<Student> allStudents)
        {
            return allStudents.FindAll(st => st.GroupNumber == 2).OrderBy(st => st.FirstName).Select(st => st).ToList();
        }
    }
}
