using System;

namespace OopTheoryLibrary
{
    public class IntArray
    {
        private readonly int[] _array;

        public IntArray(int[] array)
        {
            _array = array;
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < _array.Length)
                {
                    return _array[index];
                }

                throw new IndexOutOfRangeException($"Index must be a value between 0 and {_array.Length - 1}");
            }
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < _array.Length;i++)
            {
                sum += _array[i];
            }

            return sum;
        }
    }
}
