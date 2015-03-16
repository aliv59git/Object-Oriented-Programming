using System;

namespace MobilePhone
{

    class MobilePhoneTesting
    {
        static void Main(string[] args)
        {
            Display mobileDisplay = new Display(16777216, 12.954f); //16 M colors; 5.1" disgonal Display = 12.954 cm;
            Battery phoneBattery = new Battery("Li-Ion", 390, 21);
            BatteryType batteryModel = BatteryType.Polymer;
            Battery bat = new Battery(batteryModel, 450, 29);
            BatteryType batter = BatteryType.Ni_Cd;
            Battery batteryPhone = new Battery(batter, 270, 15);
            Battery bat1 = new Battery("Mn_Ni", 270);
            Display display = new Display(16777216, 12.70f);
            Display phoneDisplay = new Display(16777216, 12.70f);
            Display displaySony = new Display(16000000, 13.208f); //5.2"

            MobilePhone myPhone = new MobilePhone("Samsung Galaxy S5", "Samsung", 859, phoneBattery, mobileDisplay, "Ivan Penkanchin");
            Console.WriteLine("My Mobile Phone is: {0} from {1}. \nIt costed {2} leva, \nhas batery (Model: {3}, HoursIddle: {4} hours and HoursTalk: {5} hours), \ndisplay (NumberOfColcors: {6} and Size: {7} cm (5.1\")) \nand his owner instanly is {8}",
                myPhone.Model, myPhone.Manufacturer, myPhone.Price, phoneBattery.Model, phoneBattery.HoursIddle, phoneBattery.HoursTalk, mobileDisplay.NumberOfColors, mobileDisplay.Size, myPhone.Owner);
            Console.WriteLine();
            Console.WriteLine("My Phone has {0} batteri with HoursIddle {1} and HoursTalk {2}.", bat.TypeOfBattery, bat.HoursIddle, bat.HoursTalk);
            Console.WriteLine("My Phone has Capacitive TouchScreen display with {0} NumberOfColors and {1} cm diagonal (5.1 \").", mobileDisplay.NumberOfColors, mobileDisplay.Size);
            Console.WriteLine();
            MobilePhone myPhone1 = new MobilePhone("Nokia Lumia 730", "Nokia");
            Console.WriteLine("MyPhone 1 is Model: {0}, from {1}", myPhone1.Model, myPhone1.Manufacturer);
            Console.WriteLine();
            MobilePhone myPhone2 = new MobilePhone("Sony Xperia Z3v", "Sony", displaySony, "Valentin Ivanov");
            Console.WriteLine("My Phone 2 - Model: {0}, from {1}. It has {2} cm in disgonal display with {3} number of colors and its owner is {4}.",
                myPhone2.Model, myPhone2.Manufacturer, displaySony.Size, displaySony.NumberOfColors, myPhone2.Owner);
            Console.WriteLine();
            MobilePhone myPhone3 = new MobilePhone("Sony Xperia Z3v", "Sony", 849.99f, "Pepi Achev");
            Console.WriteLine("My Phone 3 - Model: {0}, from {1}. It costed {2} leva and its owner is {3}.",
                myPhone3.Model, myPhone3.Manufacturer, myPhone3.Price, myPhone3.Owner);
            Console.WriteLine();
            MobilePhone myPhone4 = new MobilePhone("Samsung Galaxy S6", "Samsung", bat, mobileDisplay);
            Console.WriteLine("My Phone 4 - Model: {0}, from {1}, with {2} battery, {3} hours Iddle and {4} hours Talk, with Super AMOLED capacitive touchscreen display, {5} colors and it's diagonal is {6} cm",
                myPhone4.Model, myPhone4.Manufacturer, bat.TypeOfBattery, bat.HoursIddle, bat.HoursTalk, mobileDisplay.NumberOfColors, mobileDisplay.Size);
            Console.WriteLine();
            MobilePhone myPhone5 = new MobilePhone("HTC One - M8 Eye", "HTC", batteryPhone, display);
            Console.WriteLine("My Phone 5 - Model: {0}, from {1}, with {2} battery, {3} hours Iddle and {4} hours Talk has Super LCD3 capacitive touchscreen {5} cm (5.0\") display with {6} number of colors.", 
                myPhone5.Model, myPhone5.Manufacturer, batteryPhone.TypeOfBattery, batteryPhone.HoursIddle, batteryPhone.HoursTalk, display.Size, display.NumberOfColors);

            Console.WriteLine();
            MobilePhone myPhone6 = new MobilePhone("Samsung Galaxy S5", "Samsung", 859, phoneBattery, phoneDisplay, "Ivan Penkanchin");
            Console.WriteLine(myPhone6.ToString());

        }
    }
}
