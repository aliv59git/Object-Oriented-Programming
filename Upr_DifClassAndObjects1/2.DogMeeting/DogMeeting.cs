using System;
class DogMeeting
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first dog name: ");
        string firstDocName = Console.ReadLine();
        Console.WriteLine("Enter first dog breed: ");
        string firstDocBreed = Console.ReadLine();
        Dog firstDoc = new Dog(firstDocName, firstDocBreed);

        Dog secondDog = new Dog();
        Console.WriteLine("Enter second dog name");
        secondDog.Name = Console.ReadLine();
        Console.WriteLine("Enter second dog breed");
        secondDog.Breed = Console.ReadLine();

        Dog thirdDog = new Dog();
        Dog[] dogCollect = new Dog[] { firstDoc, secondDog, thirdDog };

        foreach (var dog in dogCollect)
        {
            dog.SayBow();
        }


    }
}
