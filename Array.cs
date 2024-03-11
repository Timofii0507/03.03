using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._03
{
    public class Array : IOutput
    {
        private int[] _array;

        public Array(int[] array)
        {
            _array = array;
        }

        public void Show()
        {
            foreach (var element in _array)
            {
                Console.WriteLine(element);
            }
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }
    }
}
