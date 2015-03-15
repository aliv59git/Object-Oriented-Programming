using System;
class Person
{
    private string name;
    private int age;

    public Person()
    {
    }
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if ((String.IsNullOrEmpty(value)) || (value.Length <= 2) || (value.Length > 50))
            {
                throw new ArgumentOutOfRangeException("Invalid name!");
            }
            foreach (var ch in value)
            {
                if (!isAllowedCharacters(ch))
                {
                    throw new ArgumentOutOfRangeException("Invalid name!");
                }
            }
            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if ((value < 0) || (value > 120))
            {
                throw new ArgumentOutOfRangeException("Invalid Age!");
            }
            this.age = value;
        }
    }

    private bool isAllowedCharacters(char ch)
    {
        bool isAllowed = char.IsLetterOrDigit(ch) || ch == '-' || ch == ' ';
        return isAllowed;
    }
}
