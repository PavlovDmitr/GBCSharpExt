namespace lesson2hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
            int sizeM = a.GetLength(0);
            int sizeN = a.GetLength(1);
            Console.WriteLine("Не сортированный исходный массив");
            PrintArray.printArr(a);
            int[] tempArr = TransformArray.toArray(a);
            Console.WriteLine("Не сортированный одномерный массив");
            PrintArray.printArr(tempArr);
            Sort.mergeSort(tempArr, 0, tempArr.Length - 1);
            Console.WriteLine("\nСортированный одномерный массив");
            PrintArray.printArr(tempArr);
            a = TransformArray.toMatrix(tempArr, sizeM, sizeN);
            Console.WriteLine("\nСортированный 2у мерный массив");
            PrintArray.printArr(a);

        }
    }
}