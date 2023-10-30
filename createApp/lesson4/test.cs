using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4

    static void Main(string[] args)
{
var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

var numbers2 = numbers.MyWhere<int>(x => x > 3);

foreach (var number in numbers2)
{
Console.WriteLine(number);
}
//var numbers3 = EnumerableExtensions.MyWhere<int>(numbers, x => x > 3);
}

22:51
internal static class EnumerableExtensions
{
    public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> values, Func<T, bool> predicate)
    {
        foreach (var value in values)
        {
            if (predicate(value))
            {
                yield return value;
            }
        }
    }

}
{
    internal class test
    {
    }
}
