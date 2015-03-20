using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatSystem
{
    public class GenericList<T> //where T: Animal   //class //или struct/Cat...
    {
        [Author ("Ivanov")]
        private T[] elements;
        private int index;

        public GenericList()
        {
            this.elements = new T[16];
            this.index = 0;
            
        }

        public void Add(T element)
        {
            this.elements[this.index] = element;
            this.index++;
        }

        public T this[int index]
        {
            get
            {
                return this.elements[index];
            }
            set
            {
                if (index < 0 || index >= this.elements.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                this.elements[index] = value;
            }
        }



    }
}
