using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2hw
{
    public class Sort
    {
        public static void mergeSort(int[] list, int start, int end)
        {
            int mid;
            if (start < end)
            {

                mid = (start + end) / 2;
                mergeSort(list, start, mid);
                mergeSort(list, mid + 1, end);
                merge(list, start, end, mid);
            }
        }

        private static void merge(int[] list, int start, int end, int mid)
        {
            int[] mergedList = new int[list.Length];
            int i, j, k;
            i = start;
            k = start;
            j = mid + 1;

            while (i <= mid && j <= end)
            {
                if (list[i] < list[j])
                {
                    mergedList[k] = list[i];
                    k++;
                    i++;
                }
                else
                {
                    mergedList[k] = list[j];
                    k++;
                    j++;
                }
            }

            while (i <= mid)
            {
                mergedList[k] = list[i];
                k++;
                i++;
            }

            while (j <= end)
            {
                mergedList[k] = list[j];
                k++;
                j++;
            }

            for (i = start; i < k; i++)
            {
                list[i] = mergedList[i];
            }
        }

        
    }
}
