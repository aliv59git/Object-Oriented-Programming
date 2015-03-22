using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GenericList
{
    public class GenericList<T> where T : IComparable
    {
        public const int DefaultCapacity = 16;
        private T[] elements;
        private int index;

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
            this.index = 0;
        }
        public GenericList() : this(DefaultCapacity)
        {
        }

        public void Add(T element)
        {
            CHeckListElements(this.index, element);
            if (!(this.elements[this.elements.Length - 1].Equals(default(T))))
            {
                ExtendedListDoubleSize();
            }

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
                    throw new ArgumentOutOfRangeException();
                }
                this.elements[index] = value;
            }
        }
        public int Index
        {
            get
            {
                return this.index;
            }
        }

        public int IndexOf(T element)
        {
            CHeckListElements(this.index, element);

            int index = -1;
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        
        public void Remove(T element)
        {
            CHeckListElements(this.index, element);

            int index = IndexOf(element);
            this.elements[index] = default(T);
            for (int i = index; i < this.elements.Length-1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
        }

        public int Count()
        {
            int temp = -1;
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (!(this.elements[i].Equals(default(T))))
                {
                    temp = i;
                }
            }
            return temp;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.elements.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.elements[index] = default(T);
            for (int i = index; i < this.elements.Length - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
        }

        public void Insert(int index, T element)
        {
            CHeckListElements(this.index, element);

            if (!(this.elements[this.elements.Length - 1].Equals(default(T))))
            {
                ExtendedListDoubleSize();
            }
            for (int i = this.elements.Length; i >= index; i--)
            {
                this.elements[i + 1] = this.elements[i];
            }
            this.elements[index] = element;
        }

        public void ExtendedListDoubleSize()
        {
            int newLength = 2 * this.elements.Length;
            T[] newElements = new T[newLength];
            for (int i = 0; i < this.elements.Length; i++)
            {
                newElements[i] = this.elements[i];
            }
            this.elements = newElements;
        }

        public void Clear()
        {
            for (int i = 0; i < this.elements.Length; i++)
            {
                this.elements[i] = default(T);
            }
            this.index = -1;
        }

        public override string ToString()
        {
            string[] result = new string[this.elements.Length];
            for (int index = 0; index < this.elements.Length; index++)
            {
                result[index] = String.Format("{0} -> {1}", index, this.elements[index]);
            }

            return string.Join(", ", result.Select(item => item.IndexOf(item)));
        }

        public void CHeckListElements(int index, T element)
        {
            if (index < 0 || index >= this.elements.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (element.Equals(null))
            {
                throw new ArgumentNullException();
            }
        }

        public T Min()
        {
            if (this.elements.Length <= 0)
            {
                throw new ArgumentException();
            }
            T minElement = this.elements[0];
            for (int i = 1; i < this.elements.Length; i++)
            {
                if (this.elements[i].CompareTo(minElement) < 0)
                {
                    minElement = this.elements[i];
                }
            }
            return minElement;
        }
        public T Max()
        {
            if (this.elements.Length <= 0)
            {
                throw new ArgumentException();
            }
            T maxElement = this.elements[0];
            for (int i = 1; i < this.elements.Length; i++)
            {
                if (this.elements[i].CompareTo(maxElement) > 0)
                {
                    maxElement = this.elements[i];
                }
            }
            return maxElement;
        }

    }
}
