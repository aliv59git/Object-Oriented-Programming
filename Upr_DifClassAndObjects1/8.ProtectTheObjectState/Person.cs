using System;
class Person
{
    private string name;
    private int age;

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
            if(String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The name must not be empty");
            }

            if ((value.Length < 2) || (value.Length >= 50)) 
            {
                throw new ArgumentOutOfRangeException("Invalid Name! It must be longer than 2 symbols and shorter than 50 symbols.");
            }
            foreach (var ch in value)
            {
                if (!IsAllowedLetter(ch))
                {
                    throw new ArithmeticException("The number must be contain letters, '-' and ' '!");
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
            if (value < 0 || value > 120)
            {
                throw new ArgumentOutOfRangeException("Age is not valid!");
            }
            this.age = value;
        }
    }

    private bool IsAllowedLetter(char ch)
    {
        bool isAllowed = char.IsLetter(ch) || ch == ' ' || ch == '-';
        return isAllowed;
    }

}
