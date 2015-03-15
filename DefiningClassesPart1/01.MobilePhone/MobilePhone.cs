using System;

namespace MobilePhone
{

    class MobilePhone
    {
        private string model;
        private string manifacturer;
        private float price;
        private string owner;
        private Display phoneDisplay;
        private Battery phoneBattery;

        //Battery battery = new Battery("Li-Ion", 390, 21);

        //Display phoneDisplay = new Display(16777216, 12.954f); //16 M colors; 5.1" disgonal Display = 12.954 cm;


        public MobilePhone(string model, string manifacturer, float price, Battery battery, Display display, string owner) 
        {
            this.Model = model;
            this.Manifacturer = manifacturer;
            this.Price = price;
            this.PhoneBattery = phoneBattery;
            this.PhoneDisplay = phoneDisplay;
            this.Owner = owner;
        }

        public string Model { get; set; }

        public string Manifacturer { get; set; }

        public float Price { get; set; }

        public string Owner { get; set; }

        public Display PhoneDisplay { get; set; }

        public Battery PhoneBattery { get; set; }
    }
}
