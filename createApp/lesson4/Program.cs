namespace lesson4
{

    /**
     * Задача 1: Фильтрация и проекция данных с использованием LINQ
        Предоставьте студентам некоторую коллекцию объектов 
        (например, список студентов) и попросите их решить следующие задачи:

        Найти всех студентов, чей возраст меньше 25 лет.

        Вывести имена всех студентов в алфавитном порядке.

        Выбрать студентов, обучающихся на факультете инженерии.

        Посчитать средний возраст студентов.

        Попросите студентов использовать LINQ для решения этих задач.
     
     */
    class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Faculty { get; set; }
        }
    public class Program
    {
        


        static List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Age = 22, Faculty = "Engineering" },
            new Student { Name = "Bob", Age = 25, Faculty = "Science" },
            new Student { Name = "Charlie", Age = 19, Faculty = "Engineering" },
            new Student { Name = "David", Age = 30, Faculty = "Arts" },
            new Student { Name = "Eve", Age = 21, Faculty = "Science" },
            // Добавьте других студентов по вашему усмотрению
        };

        var findAge = students.Where(x => x.Age>25);
        var sortName = students.OrderBy(x => x.Name).Select(x => x.Name);
        var findEngeners = students.Where(x => x.Faculty.Equals("Engineering"));
        var averageEge = students.Average(x => x.Age);

        findAge.ToList().ForEach(x => Console.WriteLine($"{x.Name} - {x.Age}"));
        sortName.ToList().ForEach(x => Console.WriteLine($"{x}, "));
        findEngeners.ToList().ForEach(x => Console.WriteLine($"{x.Name} - {x.Faculty}"));
        Console.WriteLine(averageEge);
    }
}