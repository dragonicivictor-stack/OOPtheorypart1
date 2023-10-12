using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTheoryLibrary
{
    public static class RecursivityHelper
    {
        public static void Iterate(int[] array)
        {
            // iterate(index):
            //    print array[index]
            //    if (index + 1 < array.Length)
            //      iterate(index + 1);

            if (array != null)
            {
                IterateLeftToRight(array, 0);
            }
        }

        private static void IterateLeftToRight(int[] array, int index)
        {
            Console.WriteLine(array[index]);

            if (index + 1 < array.Length)
            {
                IterateLeftToRight(array, index + 1);
            }
        }

    }
}
