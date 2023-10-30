namespace lesson2hw_0_1
{

    class Program

    {

        static void Main(string[] args)

        {
            sortInject();
        }
        void mergeSort(int[] list, int start, int end)
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

        void merge(int[] list, int start, int end, int mid)
        {
            int[] mergedList = new int[list.Length()];
            int tr = 
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

        public static void sortInject()
        {
            int[] list = { 3, 19, 8, 0, 48, 4, 5, 12 };
            Console.WriteLine("Input array ...");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{list[i]}\t");
            }
            mergeSort(list, 0, 7);
            Console.WriteLine("\n\nSorted array ... ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{list[i]}\t");
            }
        }
    }

}
