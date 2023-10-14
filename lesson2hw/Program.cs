namespace lesson2hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sort.sortInject();
            
            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
            int[] tempArr = new int[a.GetLength(0)*a.GetLength(1)];
            int k =0;
            for (int i=0; i<a.GetLength(0); i++)
            {
                for (int j=0; j<a.GetLength(1); j++)
                {

                    tempArr[k] = a[i,j];
                    k++;
                    Console.Write(a[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("!!!!!!!!!!!!");
            for (int i = 0; i < tempArr.Length; i++)
            {
                Console.Write(tempArr[i] + " ");
            }
            Console.WriteLine("Next>>>");
            Sort.mergeSort(tempArr, 0, tempArr.Length - 1);
            for (int i=0;i<tempArr.Length;i++)
            {
                Console.Write(tempArr[i]+" ");
            }
        }
    }
}