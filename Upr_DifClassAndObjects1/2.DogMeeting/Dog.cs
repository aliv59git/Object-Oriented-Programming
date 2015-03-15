using System;
class Dog
{
    private string name;
    private string breed;

    public Dog()
    {
    }
    public Dog(string name, string breed)
    {
        this.Name = name;
        this.Breed = breed;
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (value.Length < 2 || String.IsNullOrEmpty(value) || value.Length > 20)
            {
                throw new ArgumentOutOfRangeException();
            }
            foreach (var item in value)
            {
                if (!IsLetterAllowedInName(item))
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            this.name = value;
        }
    }
    public string Breed
    {
        get
        {
            return this.breed;
        }
        set
        {
            if (value.Length < 2 || String.IsNullOrEmpty(value) || value.Length > 20)
            {
                throw new ArgumentOutOfRangeException();
            }
            foreach (var item in value)
            {
                if (!IsLetterAllowedInName(item))
                {
                    throw new ArgumentOutOfRangeException();
                }
            } 
            this.breed = value;
        }
    }

    public void SayBow()
    {
        Console.WriteLine("{0} say Bouuu!...", this.name ?? "[unnamed dog]");
    }

    private bool IsLetterAllowedInName(char ch)
    {
        bool isAllowed = char.IsLetterOrDigit(ch) || ch == '-' || ch == ' ';
        return isAllowed;
    }
}
