using System;

namespace MobilePhone
{

    class MobilePhoneTesting
    {
        static void Main(string[] args)
        {
            Display mobileDisplay = new Display(16777216, 12.954f); //16 M colors; 5.1" disgonal Display = 12.954 cm;
            Battery phoneBattery = new Battery("Li-Ion", 390, 21);
            Battery bat = new Battery("Polymer", 450, 29);
            Battery bat1 = new Battery("Mn_Ni", 270);
            Display display = new Display(8.3f);

            MobilePhone myPhone = new MobilePhone("Samsung Galaxy S5", "Samsung", 859, phoneBattery, mobileDisplay, "Ivan Penkanchin");
            Console.WriteLine("My Mobile Phone is: {0} from {1}. \nIt costed {2} leva, \nhas batery (Model: {3}, HoursIddle: {4} hours and HoursTalk: {5} hours), \ndisplay (NumberOfColcors: {6} and Size: {7} cm (5.1\")) \nand his owner instanly is {8}",
                myPhone.Model, myPhone.Manufacturer, myPhone.Price, phoneBattery.Model, phoneBattery.HoursIddle, phoneBattery.HoursTalk, mobileDisplay.NumberOfColors, mobileDisplay.Size, myPhone.Owner);
            Console.WriteLine();
            Console.WriteLine("My Phone has {0} batteri with HoursIddle {1} and HoursTalk {2}.", bat.Model, bat.HoursIddle, bat.HoursTalk);
            Console.WriteLine("My Phone has Capacitive TouchScreen display with {0} NumberOfColors and {1} cm diagonal (5.1 \").", mobileDisplay.NumberOfColors, mobileDisplay.Size);
            Console.WriteLine(display.Size);





            
        }
    }
}
