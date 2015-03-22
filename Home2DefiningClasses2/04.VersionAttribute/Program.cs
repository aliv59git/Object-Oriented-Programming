using System;


namespace _04.VersionAttribute
{
    //[Version ("3.456.788 ")]
    class Program
    {
        static void Main(string[] args)
        {
            object[] attributes = typeof(VersionAttribute).GetCustomAttributes(false);
            Console.WriteLine("Version: {0}", attributes[0]);
        }
    }
}
