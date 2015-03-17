using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MobilePhone
{
    public class PhoneCall
    {
        private DateTime date;
        private int hours;
        private int minutes;
        private string dealledPhoneNumber;
        private decimal duration;

        public PhoneCall(DateTime date, int hours, int minutes, string dealledPhoneNumber, decimal duration)
        {
            this.Date = date;
            this.Hours = hours;
            this.Minutes = minutes;
            this.DealledPhoneNumber = dealledPhoneNumber;
            this.Duration = duration;
        }



        public DateTime Date { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public string DealledPhoneNumber { get; private set; }
        public decimal Duration { get; set; }

    }
}
