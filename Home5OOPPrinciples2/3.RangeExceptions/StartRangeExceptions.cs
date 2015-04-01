using System;
using System.Collections.Generic;


namespace _3.RangeExceptions
{
    public class StartRangeExceptions
    {
        static void Main(string[] args)
        {
            try
            {
                throw new InvalidRangeException<int>("Invalid numbers! The numbers ", 1, 100);
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine("Numbers: {0}", ex.Message);
            }
            Console.WriteLine();
            try
            {
                throw new InvalidRangeException<DateTime>("Date ", new DateTime(1980, 1, 1), DateTime.Now);
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine("Invalid date! {0}", ex.Message);
            }

        }
    }
}
