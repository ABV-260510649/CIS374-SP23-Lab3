using Lab3.SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Sorting_Algorithms
{
    internal class PigeonholeSort : ISortableInt
    {
        public int[] Sort(int[] array)
        {
            int n  = array.Length;
            int min = array[0];
            int max = array[0];
            int range, i, j, index;

            for (int a = 0; a < n; a++)
            {
                if (array[a] > max)
                    max = array[a];
                if (array[a] < min)
                    min = array[a];
            }

            range = max - min + 1;
            int[] phole = new int[range];

            for (i = 0; i < range; i++)
            {
                phole[i] = 0;         
            }
                

            for (i = 0; i < n; i++)
            {
                phole[array[i] - min]++;
            }
                


            index = 0;

            for (j = 0; j < range; j++)
            {
                while (phole[j]-- > 0)
                {
                    array[index++] = j + min;
                }
                    
            }


            return array;
        }
    }
    
}
