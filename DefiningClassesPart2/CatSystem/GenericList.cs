using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatSystem
{
    public class GenericList<T>
    {
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

    }
}
