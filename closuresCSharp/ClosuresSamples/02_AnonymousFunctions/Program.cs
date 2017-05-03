using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace _02_AnonymousFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var result = CompareEmployees(Employee.GenerateEmployees(100));
            WriteLine($"{result.Name} - {result.Salary}");
        }

        public static Employee CompareEmployees(IList<Employee> employees)
        {
            int timesCalled = 0;
            Func<Employee, Employee, Employee> biggerSalary = (left, right) =>
            {
                timesCalled++;
                return (left.Salary > right.Salary) ? left : right;
            };
            Employee result = employees.First();
            foreach (var employee in employees.Skip(1))
            {
                result = biggerSalary(result, employee);
            }
            Console.WriteLine(timesCalled);
            return result;
        }
    }
}