using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatSystem
{
    public class StringCouple 
    {
        private List<string> keys;
        private List<string> values;

        public StringCouple()
        {
            this.keys = new List<string>();
            this.values = new List<string>();
        }

        public string this[string index] //moje i poveche indexi da ima;
        {
            get
            {
                var indexInKeys = this.keys.IndexOf(index);
                if (indexInKeys < 0)
                {
                    throw new ArgumentException("Index not found!");
                }
                return this.values[indexInKeys];
            }
            set
            {
                var indexInKeys = this.keys.IndexOf(index);
                this.values[indexInKeys] = value;
            }
        } 


        public void Add(string key, string value)
        {
            this.keys.Add(key);
            this.values.Add(value);
        }


    }
}
