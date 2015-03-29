using System;


namespace _3.AnimalHierarchy
{
    public class Tomcat : Cat
    {
        public Tomcat(int age, string name, string sex)
            : this(name)
        {
            this.Age = age;
            this.Sex = "Male";
        }
        public Tomcat(string name)
            : this()
        {
            this.Name = name;
        }
        public Tomcat()
        {
        }
    }
}
