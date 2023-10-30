namespace lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            task1();
            int[] arr = new int[1];
            task2(arr);
            task3(arr);
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.Write(arr[i]);
                Console.Write(" ");

            }

        }

        static void task1() 
        {


            //Написать программу, подсчитывающую количество чисел от 0 до 1000, делящихся на 3 без остатка.
            //Вывести результат на печать.


            int count = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0) count++;
            }

            Console.WriteLine(count);


            string number = Console.ReadLine();
            for (int i = 0; i < number.Length; i++) { }
        }

        static void task2(int[] res)
        {
            //Необходимо создать массив c длиной, равной сумме 
            //    длин массивов a и b, заполнить его элементами
            //    массивов a и b, отсортированными по возрастанию.

            int[] a = { 9, 3, 4, 4, 5, 6, 1, 4, 7, 9, 0 };
            int[] b = { 1, 2, 3, 3, 9, 9, 1, 9, 9, 0, 0, 1, 1, 7 };


            res = new int[a.Length+b.Length];

            for (int i = 0;i < a.Length;i++)
            {
                res[i] = a[i];
            }
            for (int i = a.Length;i< res.Length; i++)
            {
                res[i] = b[i - a.Length];
            }

            
        }

        static void task3(int[] res)
        {
            int swap = 0;
            for (int i = 0; i< res.Length-1; i++)
            {
                for(int j = i; j< res.Length; j++)
                {
                    if (res[j] < res[i])
                    {
                        swap = res[i];
                        res[i] = res[j];
                        res[j] = swap;
                    }
                }
            }
        }
    }
}