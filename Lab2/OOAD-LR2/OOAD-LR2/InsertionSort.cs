using System;
using System.Collections.Generic;
using System.Text;

namespace OOAD_LR2
{
    public class InsertionSort
    {
        int[] sort = new int[6];
        public InsertionSort(int[] arr)
        {
            sort = arr;
        }
        public int[] Sort()
        {
            if (sort != null)
            {
                for (int i = 1; i < sort.Length; i++)
                    for (int j = i; j > 0 && sort[j - 1] > sort[j]; j--) // пока j>0 и элемент j-1 > j, x-массив int
                        (sort[j - 1], sort[j]) = (sort[j], sort[j - 1]); // меняем местами элементы j и j-1
                return sort;
            }
            else
            {
                throw new ArgumentException("Массив пустой");
            }
        }
        public int[] ShowArray()
        {
            return sort;
        }
    }
}
