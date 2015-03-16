using System;

namespace MobilePhone
{
    public enum BatCollection 
    {
        LI_Ion, Mn_Ni, Polymer 
    }
    
    public class Battery
    {
        private string model;
        private int hoursIddle;
        private byte hoursTalk;

        public Battery() 
        { 
        }

        public Battery(string model, int hoursIddle, byte hoursTalk)
        {
            this.Model = model;
            this.HoursIddle = hoursIddle;
            this.HoursTalk = hoursTalk;
        }
        public Battery(string model)
        {
            this.Model = model;
        }
        public Battery(string model, int hoursIddle)
        {
            this.Model = model;
            this.HoursIddle = hoursIddle;
        }
        public Battery(string model, byte hoursTalk)
        {
            this.Model = model;
            this.HoursTalk = hoursTalk;
        }


        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                if (value.Length < 2 || value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException();
                }
                foreach (var ch in value)
                {
                    if (!IsAllowedLetterOrDigit(ch))
                    {
                        throw new ArithmeticException("Invalid Model!");
                    }
                }
                this.model = value;
            }
        }
        public int HoursIddle 
        {
            get { return this.hoursIddle; }
            set 
            {
                if (value <= 0 || value > 1000)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.hoursIddle = value;
            }
        }
        public byte HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value <= 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.hoursTalk = value;
            }
        }

        public bool IsAllowedLetterOrDigit(char ch)
        {
            bool isAllowed = Char.IsLetterOrDigit(ch) || ch == '-' || ch == ' '||ch == '_';
            return isAllowed;
        }
    }
}
