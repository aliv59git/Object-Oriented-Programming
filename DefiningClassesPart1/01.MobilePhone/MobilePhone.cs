using _01.MobilePhone;
using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.MobilePhone
{

    public class MobilePhone
    {
        private string model;
        private string manufacturer;
        private float price;
        private string owner;
        private Display phoneDisplay;
        private Battery phoneBattery;
        public static string IPhone4SInfo = "IPhone4S has LED-backlit IPS LCD, capacitive touchscreen, 16M colors, Size: 3.5\", Non-removable Li-Po 1432 mAh battery (hoursIddle=200 h, hoursTalk = 14 h); This is from Apple and has been released in 2011. With iOS 5, Bluetooth 4.0, жироскоп, двуядрен процесор A5 it looks nice well.";
        private PhoneCall phoneCall;   
        private List<PhoneCall> callHistory = new List<PhoneCall>();

        public MobilePhone(string model, string manufacturer, float price, Battery phoneBattery, Display phoneDisplay, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.PhoneBattery = phoneBattery;
            this.PhoneDisplay = phoneDisplay;
            this.Owner = owner;
        }
        public MobilePhone(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }
        public MobilePhone(string model, string manufacturer, Display phoneDisplay, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
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

        public List<PhoneCall> CallHistory
        {
            get { return this.callHistory; }
        }

        public override string ToString()
        {
            return string.Format("My Phone is: Model: {0} from {1}. \nIt costed {2} leva, has batery{3}, display{4} and his owner instanly is {5}.",
                this.Model, this.Manufacturer, this.Price, this.phoneBattery, this.phoneDisplay, this.Owner);
        }

        public void AddPhoneCall(PhoneCall phoneCall)
        {
            this.callHistory.Add(phoneCall);
        }
        public void DeletePhoneCall(PhoneCall phoneCall)
        {
            int index = this.callHistory.IndexOf(phoneCall);
            if (index != -1)
            {
                this.callHistory.RemoveAt(index);
            }
        }
        public void ClearPhoneHistory()
        {
            this.callHistory.Clear();
        }



        public static decimal CalculateTotalPrice(List<PhoneCall> callHistory, decimal priceOfMinutePhoneCall)
        {
            decimal result = 0.0m;
            foreach (var item in callHistory)
            {
                result += (Math.Floor((decimal)item.Duration) + 1) * priceOfMinutePhoneCall;
            }

            return result;
        }

        public bool IsAllowedLetter(char ch)
        {
            bool isAllowed = Char.IsLetter(ch) || ch == '-' || ch == ' ';
            return isAllowed;
        }

        public bool IsAllowedLetterOrDigit(char ch)
        {
            bool isAllowed = Char.IsLetterOrDigit(ch) || ch == '-' || ch == ' '|| ch == '_';
            return isAllowed;
        }
    }
}
