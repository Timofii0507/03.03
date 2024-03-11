using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._03
{
    public class Array2 : IMath
    {
        private readonly int[] _data;

        public Array2(int[] data)
        {
            _data = data;
        }

        public int Max()
        {
            int max = _data[0];
            for (int i = 1; i < _data.Length; i++)
            {
                if (_data[i] > max)
                {
                    max = _data[i];
                }
            }

            return max;
        }

        public int Min()
        {
            int min = _data[0];
            for (int i = 1; i < _data.Length; i++)
            {
                if (_data[i] < min)
                {
                    min = _data[i];
                }
            }

            return min;
        }

        public float Avg()
        {
            float sum = 0;
            foreach (int value in _data)
            {
                sum += value;
            }

            return sum / _data.Length;
        }

        public bool Search(int valueToSearch)
        {
            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i] == valueToSearch)
                {
                    return true;
                }
            }

            return false;
        }
    }

}
