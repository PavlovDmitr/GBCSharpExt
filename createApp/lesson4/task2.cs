using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    //Отсортировать заказы по сумме в убывающем порядке.
    //Сгруппировать заказы по клиентам и вывести количество заказов для каждого клиента.
    //Найти клиента с наибольшей суммой заказов.
    //Вывести список клиентов и общую сумму их заказов.
    //Попросите студентов использовать LINQ для сортировки и группировки данных.

    class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
    }
    internal class Program2
    {
        private static void Main(string[] args)
        {
            List<Order> orders = new List<Order>
            {
                new Order { OrderID = 1, CustomerName = "Alice", OrderDate = new DateTime(2023, 6, 1), TotalAmount = 150.0 },
                new Order { OrderID = 2, CustomerName = "Bob", OrderDate = new DateTime(2023, 6, 2), TotalAmount = 75.5 },
                new Order { OrderID = 3, CustomerName = "Charlie", OrderDate = new DateTime(2023, 6, 2), TotalAmount = 220.0 },
                new Order { OrderID = 4, CustomerName = "David", OrderDate = new DateTime(2023, 6, 3), TotalAmount = 100.0 },
                new Order { OrderID = 5, CustomerName = "Eve", OrderDate = new DateTime(2023, 6, 4), TotalAmount = 85.5 },
                // Добавьте другие заказы по вашему усмотрению
            };

            var sum = orders.OrderByDescending(x => x.TotalAmount);
            var sum2 = from order in orders
                       orderby order.TotalAmount
                       select order;

            var totalAmountForClients = orders.GroupBy(x => x.CustomerName).Select(x => new { name = x.Key, count = x.Count() });

            var richClient = orders
                .GroupBy(x => x.CustomerName)
                .Select(x => new { name = x.Key, sumTottalAmount = x.Sum(ta => ta.TotalAmount) })
                .OrderBy(ta => ta.sumTottalAmount).First().name;

            var clienttsTA = orders
                .GroupBy(x => x.CustomerName)
                .Select(x => new { name = x.Key, sumTottalAmount = x.Sum(ta => ta.TotalAmount) });


            sum.ToList().ForEach(x => Console.WriteLine($"{x.CustomerName} - {x.TotalAmount}"));

            totalAmountForClients.ToList().ForEach(x => Console.WriteLine($"{x.name}, {x.count}"));

            Console.WriteLine(richClient);

            clienttsTA.ToList().ForEach(x => Console.WriteLine($"{x.name} - {x.sumTottalAmount}"));

        }
    }
}
