using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2hw
{
    internal class PrintArray
    {
        public static void printArr(int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public static void printArr(int[,] arr) 
        {
            for (int i = 0;i < arr.GetLength(0);i++)
            {
                for (int j = 0; j < arr.GetLength(1);j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
