namespace ClassesPartTwo.Generics
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GenericList<T> : IEnumerable<T>
        where T : IComparable
    {
        //Instance fields
        private T[] myList;
        private int nextIndex;
        private int capacity;
        private int count;

        //Constructor
        public GenericList(int capacity)
        {
            this.myList = new T[capacity];
            this.nextIndex = 0;
            this.Capacity = capacity;
            this.Count = 0;
        }

        #region Methods
        public void Add(T element)
        {
            if (this.nextIndex == Capacity)
            {
                Capacity = myList.Length * 2;
                T[] tempArr = myList;
                myList = new T[capacity];
                for (int i = 0; i < tempArr.Length; i++)
                {
                    myList[i] = tempArr[i];
                }
            }

            this.myList[nextIndex] = element;
            nextIndex++;
            Count++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= myList.Length)
                {
                    throw new ArgumentOutOfRangeException("Index is out of the bounds of the array");
                }

                return this.myList[index];
            }
            set
            {
                if (index < 0 || index >= myList.Length)
                {
                    throw new ArgumentOutOfRangeException("Index is out of the bounds of the array");
                }

                this.myList[index] = value;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException("Index is out of the bounds of the array");
            }
            else
            {
                var newList = myList.ToList();
                newList.RemoveAt(index);
                myList = newList.ToArray();
                Count--;
            }
        }

        public void Insert(int index, T element)
        {
            if (index < 0 || index > Count)
            {
                throw new ArgumentOutOfRangeException("Index is out of the bounds of the array");
            }
            else
            {
                var tempList = myList.ToList();
                tempList.Insert(index, element);
                myList = tempList.ToArray();
                Count++;
            }
        }

        public void Clear()
        {
            var tempList = myList.ToList();
            tempList.Clear();
            myList = tempList.ToArray();
            Count = 0;
        }

        public int Find(T element)
        {
            var tempList = myList.ToList();
            int index = tempList.IndexOf(element);
            return index;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            for (int i = 0; i < Count; i++)
            {
                result.AppendLine(myList[i].ToString());
            }

            result.Remove(result.Length - 1, 1);

            return result.ToString();
        }

        public T Min()
        {
            T min = myList[0];

            for (int i = 0; i < this.Count; i++)
            {
                if (min.CompareTo(myList[i]) > 0)
                {
                    min = myList[i];
                }
            }

            return min;
        }

        public T Max()
        {
            T max = default(T);

            for (int i = 0; i < this.Count; i++)
            {
                if (max.CompareTo(myList[i]) < 0)
                {
                    max = myList[i];
                }
            }

            return max;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                T element = this.myList[i];
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion

        #region Properties
        public int Capacity
        {
            get
            {
                return this.myList.Length;
            }
            private set
            {
                this.capacity = value;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }
        #endregion
    }
}

