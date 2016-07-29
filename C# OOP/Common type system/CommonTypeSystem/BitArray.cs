namespace CommonTypeSystem
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray : IEnumerable<int>
    {
        private const int ArrLength = 64;
        private int[] bits = new int[ArrLength];

        public BitArray(ulong number)
        {
            string binary = ConvertToBinary(number);
            this.bits = FillingBitArray(bits, binary);
        }

        public int Length
        {
            get { return ArrLength; }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException("Out of range!");
                }

                return this.bits[index];
            }
        }
        
        public override string ToString()
        {
            return string.Join("", this.bits);
        }

        private string ConvertToBinary(ulong number)
        {
            var result = string.Empty;

            while (number > 0)
            {
                var digit = number % 2;
                result += digit;
                number /= 2;
            }

            return result;
        }

        private int[] FillingBitArray(int[] arr, string binary)
        {
            for (int i = 0, j = arr.Length - 1; i < binary.Length; i++, j--)
            {
                arr[j] = int.Parse(binary[i].ToString());
            }

            return arr;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.bits.Length; i++)
            {
                yield return this.bits[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override int GetHashCode()
        {
            int hash = this.bits.GetHashCode();
            return 42 * hash;
        }

        public override bool Equals(object otherBitArray)
        {
            if (otherBitArray == null)
            {
                return false;
            }

            BitArray array = otherBitArray as BitArray;
            if ((Object)array == null)
            {
                return false;
            }

            return this == array;
        }

        public static bool operator !=(BitArray first, BitArray second)
        {
            if (first.Length == second.Length)
            {
                bool equal = false;

                for (int i = 0; i < first.Length; i++)
                {
                    if (first[i] != second[i])
                    {
                        equal = true;
                    }
                }

                return equal;
            }

            return true;
        }

        public static bool operator ==(BitArray first, BitArray second)
        {
            if (first.Length == second.Length)
            {
                bool equal = true;

                for (int i = 0; i < first.Length; i++)
                {
                    if (first[i] != second[i])
                    {
                        equal = false;
                    }
                }

                return equal;
            }

            return false;
        }
    }
}
