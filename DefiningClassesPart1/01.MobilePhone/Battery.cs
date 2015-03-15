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
        private int hoursTalk;

        public Battery(string model, int hoursIddle, int hoursTalk)
        {
            this.Model = model;
            this.HoursIddle = hoursIddle;
            this.HoursTalk = hoursTalk;
        }

        public Battery(Battery bat)
        {
            bat.Model = "BatCollection.Polymer";
            bat.HoursIddle = 390;
            bat.HoursTalk = 21;
        }

        public string Model { get; set; }
        public int HoursIddle 
        {
            get { return this.hoursIddle; }
            set { this.hoursIddle = value; }
        }
        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }


    }
}
