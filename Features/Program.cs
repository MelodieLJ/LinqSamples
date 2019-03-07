using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) => x + y;

            Console.WriteLine(square(add(1,2)));

            //an array of Employee
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee {Id = 1, Name = "Melodie"},
                new Employee {Id = 2, Name = "Art"},
                new Employee {Id = 4, Name = "Mel"}
            };

            //a List of Employee
            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee {Id = 3, Name = "Joseph"}
            };

            //Console.WriteLine(developers.Count());
            //IEnumerator<Employee> enumerator = developers.GetEnumerator();
            //while(enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current.Name);
            //}

            //foreach (var employee in developers.Where( e => e.Name.Length == 3)
            //                                   .OrderBy(e => e.Name))

            //{
            //    Console.WriteLine(employee.Name);
            //}

            //Method Syntax
            var query = developers.Where(e => e.Name.Length == 3)
                                    .OrderBy(e => e.Name)
                                    .Select(e => e);

            //Query Syntax
            var query2 = from developer in developers
                        where developer.Name.Length == 3
                        orderby developer.Name
                        select developer;

            foreach (var employee in query)
            {
                Console.WriteLine(employee.Name);
            }
        }

    }
}
