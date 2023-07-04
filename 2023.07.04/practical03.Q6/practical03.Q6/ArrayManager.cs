using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical03.Q6
{
    internal class ArrayManager
    {
        public int[] CreateArray(int size)
        {
            return new int[size * 2];
        }

        public void SetValue(int[] array, int index, int value)
        {
            array[index * 2] = value;
            array[(index * 2) + 1] = 0;
        }
    }
}
