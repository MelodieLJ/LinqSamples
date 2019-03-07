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
            //an array of Employee
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee {Id = 1, Name = "Melodie"},
                new Employee {Id = 2, Name = "Art"}
            };

            //a List of Employee
            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee {Id = 3, Name = "Joseph"}
            };

            IEnumerator<Employee> enumerator = developers.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Name);
            }

        }
    }
}
