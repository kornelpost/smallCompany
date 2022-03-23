using smallCompany.Models;
using System;
using System.Linq;


namespace smallCompany.Data
{
    public static class DbInitializer
    {
        public static void Initialize(assignmentContext context)
        {
            context.Database.EnsureCreated();

            if (context.Employees.Any())
            {
                return; // DB already fulfiffled with test data
            }

            var employees = new Employee[]
            {
                new Employee {FirstName = "Dawid", LastName = "Post"}
            };
            foreach (Employee e in employees)
            {
                context.Employees.Add(e);
            }
            context.SaveChanges();

            var tasks = new Task[]
            {
                new Task { TaskName = "Remont glowicy Renault", Details = "Plaszczyzna, wymiana prowadnic komplet, szlif zaworów komplet"}
            };
            foreach (Task t in tasks)
            {
                context.Tasks.Add(t);
            }
            context.SaveChanges();

            var assignments = new Assignment[]
            {
                new Assignment { EmployeeID = 1, TaskID = 1}
            };
            foreach (Assignment a in assignments)
            {
                context.Assignments.Add(a);
            }
            context.SaveChanges();
        }
    }
}
