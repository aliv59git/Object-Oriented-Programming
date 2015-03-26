using System;
using System.Collections.Generic;

namespace SchoolSystem
{

    public class ScoolSystem
    {
        static void Main()
        {
            Student student = new Student("Ivan", "val@sdfer.com", 12341234);
            Teacher teacher = new Teacher( "Dragan", "asdfa@abv.bg", "Biology");
            UniversityProfessor professor = new UniversityProfessor();
            student.Walk();
            List<int> list = new List<int>();



        }
    }
}