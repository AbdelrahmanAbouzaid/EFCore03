using InheritanceExample.Contexts;
using InheritanceExample.Models;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();

            //FullTimeEmployee employee01 = new FullTimeEmployee()
            //{
            //    Name = "Abdelrahman",
            //    Address = "Cairo",
            //    Age = 22,
            //    Email = "abdo@g.c",
            //    Salary = 12000
            //};

            //context.FullTimeEmployees.Add(employee01);


            //FullTimeEmployee employee02 = new FullTimeEmployee()
            //{
            //    Name = "Toqa",
            //    Address = "Giza",
            //    Age = 21,
            //    Email = "toqa@g.c",
            //    Salary = 11000
            //};

            //context.FullTimeEmployees.Add(employee02);

            //FullTimeEmployee employee03 = new FullTimeEmployee()
            //{
            //    Name = "Omar",
            //    Address = "Alex",
            //    Age = 20,
            //    Email = "Omar@g.c",
            //    Salary = 10000
            //};

            //context.FullTimeEmployees.Add(employee03);

            //PartTimeEmployee employee04 = new PartTimeEmployee()
            //{
            //    Name = "Ahmed",
            //    Address = "Cairo",
            //    Age = 24,
            //    Email = "ahmed@g.c",
            //    HourRate = 200,
            //    NumberOfHours = 60,
            //};
            //context.PartTimeEmployees.Add(employee04);

            //PartTimeEmployee employee05 = new PartTimeEmployee()
            //{
            //    Name = "Khadeja",
            //    Address = "Alex",
            //    Age = 22,
            //    Email = "khadeja@g.c",
            //    HourRate = 200,
            //    NumberOfHours = 60,
            //};
            //context.PartTimeEmployees.Add(employee05);

            //PartTimeEmployee employee06 = new PartTimeEmployee()
            //{
            //    Name = "Salma",
            //    Address = "Giza",
            //    Age = 22,
            //    Email = "salma@g.c",
            //    HourRate = 200,
            //    NumberOfHours = 60,
            //};
            //context.PartTimeEmployees.Add(employee06);

            //context.SaveChanges();

            //var result = context.Employees;
            //var result = context.Employees.OfType<FullTimeEmployee>();

            //foreach (Employee employee in result)
            //    Console.WriteLine(employee.Name);

        }
    }
}
