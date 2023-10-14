using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2hw
{
    internal class TransformArray
    {
        public static int[] toArray(int[,] matrix)
        {
            int[] tempArr = new int[matrix.GetLength(0)*matrix.GetLength(1)];
            int index = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    tempArr[index] = matrix[i, j];
                    index++;
                }
            }
            return tempArr;
        }

        public static int[,] toMatrix(int[] array, int sizeM, int sizeN) 
        {
            if (sizeM * sizeN != array.Length) 
            {
                throw new IndexOutOfRangeException($"{nameof(array)}," +
                    $" Size of array must be equals mult {nameof(sizeM)} and {nameof(sizeN)}"); 
            }
            int[,] tempArr = new int[sizeM,sizeN];
            int index = 0;
            for (int i = 0; i < tempArr.GetLength(0); i++)
            {
                for (int j = 0; j < tempArr.GetLength(1); j++)
                {
                    tempArr[i, j] = array[index];
                    index++;
                }
            }
            return tempArr;
        }
    }
}
