namespace Chapter9.Models
{
    using System;
    using System.Collections.Generic;

    public class Employee
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Salary { get; set; }

        // Constructor
        public Employee(int id, string firstName, string lastName, string position, string salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            Salary = salary;
        }

        public static List<Employee> GenerateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string[] firstNames = { "John", "Jane", "Alex", "Emily", "Michael", "Sarah", "David", "Laura", "Chris", "Jessica", "James", "Sophia", "Daniel", "Olivia", "Matthew", "Emma", "Andrew", "Isabella", "Joshua", "Mia" };
            string[] lastNames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez", "Hernandez", "Lopez", "Gonzalez", "Wilson", "Anderson", "Thomas", "Taylor", "Moore", "Jackson", "Martin" };
            string[] positions = { "Software Engineer", "Product Manager", "Designer", "QA Engineer", "HR Specialist", "Data Analyst", "DevOps Engineer", "Marketing Specialist", "Sales Representative", "Support Specialist" };

            Random random = new Random();

            for (int i = 0; i < 50; i++)
            {
                int id = i + 1;
                string firstName = firstNames[random.Next(firstNames.Length)];
                string lastName = lastNames[random.Next(lastNames.Length)];
                string position = positions[random.Next(positions.Length)];
                decimal salary = random.Next(50000, 120000);

                employees.Add(new Employee(id, firstName, lastName, position, salary.ToString("C")));
            }

            return employees;
        }
    }
}
