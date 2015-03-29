using System;
using System.Collections;


namespace _1.SchoolClasses
{
    class Subject : IComments
    {
        private string subjectName;
        private int numberOfLectures;
        private int numberOfExcesies;
        private string comments;

        public Subject(string subjectName, int numberOfLectures, int numberOfExcesises, string comment)
            : this(subjectName)
        {
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExcesies;
            this.Comments = comments;
        }
        public Subject(string subjectName)
            : this()
        {
            this.SubjectName = subjectName;
        }
        public Subject()
        {
        }

        public string SubjectName { get; protected set; }
        public int NumberOfLectures { get; protected set; }

        public int NumberOfExercises { get; protected set; }
        public string Comments { get; set; }

        public override string ToString()
        {
            return string.Format("Subject: {0}, Comments: {1}", this.subjectName, this.comments);
        }

    }
}
