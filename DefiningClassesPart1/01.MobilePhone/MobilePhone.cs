using System;

namespace MobilePhone
{

    public class MobilePhone
    {
        private string model;
        private string manufacturer;
        private float price;
        private string owner;
        private Display phoneDisplay;
        private Battery phoneBattery;

        //Battery phoneBattery = new Battery("Li-Ion", 390, 21);

        //Display phoneDisplay = new Display(16777216, 12.954f); //16 M colors; 5.1" disgonal Display = 12.954 cm;


        public MobilePhone(string model, string manufacturer, float price, Battery phoneBattery, Display phoneDisplay, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.PhoneBattery = phoneBattery;
            this.PhoneDisplay = phoneDisplay;
            this.Owner = owner;
        }
        public MobilePhone(string model, string manifacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }
        public MobilePhone(string model, string manifacturer, Display phoneDisplay, string owner)
        {
            this.Model = model;
            this.Manufacturer = manifacturer;
            this.PhoneDisplay = phoneDisplay;
            this.Owner = owner;
        }
        public MobilePhone(string model, string manufacturer, float price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }
        public MobilePhone(string model, string manufacturer, Battery phoneBattery, Display phoneDisplay)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.PhoneBattery = phoneBattery;
            this.PhoneDisplay = phoneDisplay;
        }
        public MobilePhone(string model, string manufacturer, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;

        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The mobile phone has'n model!");
                }
                foreach (var ch in value)
                {
                    if (!IsAllowedLetterOrDigit(ch))
                    {
                        throw new ArgumentOutOfRangeException("Invalid Model");
                    }
                }
                this.model = value;
            }
        }

        public string Manufacturer 
        {
            get { return this.manufacturer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("You are'n enter manufacturer!");
                }
                if (value.Length <2 ||value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException();
                }
                foreach (var item in value)
                {
                    if(!IsAllowedLetterOrDigit(item))
                    {
                        throw new ArgumentException();
                    }
                }
                this.manufacturer = value;
            }
        }

        public float Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0 || value > 20000)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("You are'n enter manufacturer!");
                }
                if (value.Length < 2 || value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException();
                }
                foreach (var item in value)
                {
                    if (!IsAllowedLetter(item))
                    {
                        throw new ArgumentException();
                    }
                }
                this.owner = value;
            }
        }

        public Display PhoneDisplay { get; set; }

        public Battery PhoneBattery { get; set; }


        public bool IsAllowedLetter(char ch)
        {
            bool isAllowed = Char.IsLetter(ch) || ch == '-' || ch == ' ';
            return isAllowed;
        }

        public bool IsAllowedLetterOrDigit(char ch)
        {
            bool isAllowed = Char.IsLetterOrDigit(ch) || ch == '-' || ch == ' ';
            return isAllowed;
        }
    }
}
