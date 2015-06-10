namespace GenericList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MyList<T> where T : IComparable, new()
    {
        const int initialCapacity = 4;

        private T[] list;
        private int count;
        private int capacity;

        public int Capacity
        {
            get { return this.capacity; }
            private set { this.capacity = value; }
        }

        public MyList(int capacity)
        {
            this.list = new T[capacity];
            this.Capacity = capacity;
        }

        public MyList()
        {
            this.list = new T[initialCapacity];
            this.count = 0;
            this.Capacity = initialCapacity;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Add(T element)
        {
            if (count >= list.Length)
            {
                this.DoubleSize();
            }
            this.list[count] = element;
            count++;
        }

        public T RemoveAt(int index)
        {
            if (index >= count || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            T result = list[index];

            for (int i = index; i < count - 1; i++)
            {
                this.list[i] = this.list[i + 1];
            }

            this.list[count - 1] = new T();
            count--;
            return result;
        }

        public void InsertAt(int index, T element)
        {
            if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }

            if (index == count)
            {
                this.Add(element);
                return;
            }

            if (count >= this.list.Length - 1)
            {
                this.DoubleSize();
            }

            count++;

            for (int i = count; i > index; i--)
            {
                this.list[i] = this.list[i - 1];
            }

            this.list[index] = element;
        }

        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = list[index];
                return result;
            }
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (this.list[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Clear()
        {
            this.list = new T[initialCapacity];
            this.count = 0;
            this.Capacity = initialCapacity;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(list[i]);
                if (i < count - 1)
                {
                    result.Append(", ");
                }
            }

            return result.ToString();
        }

        private void DoubleSize() 
        {
            int newSize = this.list.Length * 2;
            T[] tempList = new T[newSize];

            for (int i = 0; i < count; i++)
            {
                tempList[i] = this.list[i];
            }

            this.list = tempList;
            this.Capacity *= 2;
        }

        public T Min() 
        {
            T min = this.list[0];

            for (int i = 0; i < count; i++)
            {
                if (this.list[i].CompareTo(min) < 0)
                {
                    min = this.list[i];
                }
            }
            return min;
        }

        public T Max() 
        {
            T max = this.list[0];

            for (int i = 0; i < count; i++)
            {
                if (this.list[i].CompareTo(max) > 0)
                {
                    max = this.list[i];
                }
            }
            return max;
        }
    }
}
