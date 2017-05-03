using System;
using System.Collections;
using System.Collections.Generic;
using Bogus;

namespace _02_AnonymousFunctions
{
    public class Employee
    {
        private string _name;
        private int _salary;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Salary
        {
            get => _salary;
            set => _salary = value;
        }

        public static IList<Employee> GenerateEmployees(int count)
        {
            var resultList = new List<Employee>();
            var faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                resultList.Add(new Employee()
                {
                    Name = faker.Name.FindName(),
                    Salary = Convert.ToInt32(faker.Finance.Amount())
                });
            }
            return resultList;
        }
    }
}