using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    internal class Task3
    {

        //В этой задаче у вас есть список строк,
        //и ваша задача – отсортировать этот список в порядке возрастания длины строк,
        //используя лямбда-выражение.Ниже приведены начальные данные и возможное решение:
        public static void Main2()
        {

            List<string> strings2 = new()
                {
                    "Apple",
                    "Banana",
                    "Cherry",
                    "Date",
                    "Fig",
                    "Grapes"
                };

            strings2.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));



            List<int> numbers = new() { 1, 2, 3, 324, 32432, 4, 32423, 432, 432, 4, 324, 234 };

            numbers.Sort((x, y) => y.CompareTo(x));

            numbers.ForEach(x => Console.WriteLine(x));

            List<string> words = new()
            {
                    "apple",
                    "banana",
                    "cherry",
                    "date",
                    "grape",
                    "kiwi",
                    "lemon",
                };

            string searchTerm = "an";


            words.Where(x => x.Contains(searchTerm)).ToList().ForEach(Console.WriteLine);


            HashSet<int> hashSet = new() { 1, 2, 3, 4, 5 };
            List<int> list = new() { 3, 4, 5, 6, 7 };

            var hashSet2 = hashSet.Intersect(list);
        }

    }
}

    
