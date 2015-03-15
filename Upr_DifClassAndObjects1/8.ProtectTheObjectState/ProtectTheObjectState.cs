using System;
class ProtectTheObjectState
{
    static void Main(string[] args)
    {
        Person firstPerson = new Person("Adam Evin", 22);
        Console.WriteLine("The First person is {0}. Hi has {1} years old when met Eva.", firstPerson.Name, firstPerson.Age);

        Console.WriteLine("Please, enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine("Please, enter your age: ");
        int age = int.Parse(Console.ReadLine());

        try
        {
            Person person = new Person(name, age);
            Console.WriteLine("Hellow, {0}! ", person.Name);
            Console.WriteLine("Your age is: {0}.", person.Age);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Can not create person object: "+ ex.Message);
            throw;
        }
    }
}
