using Company.Contexts;
using Company.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();
            #region Loading Navigational Property

            //List<Department> departments = new List<Department>()
            //{
            //    new Department(){ Name = "HR"},
            //    new Department(){ Name = "PR"},
            //    new Department(){ Name = "IT"},
            //};

            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee() {Name = "Abdelrahman", Address="Cairo",Age=22,Salary=12000,DeptId = 100  },
            //    new Employee() {Name = "Toqa", Address="Giza",Age=21,Salary=12000,DeptId = 100  },
            //    new Employee() {Name = "Ahmed", Address="Alex",Age=20,Salary=12000,DeptId = 200  },
            //    new Employee() {Name = "Omar", Address="Cairo",Age=18,Salary=12000,DeptId = 200  },
            //    new Employee() {Name = "Salma", Address="Giza",Age=19,Salary=12000,DeptId = 300  },
            //};

            //context.AddRange(departments);
            //context.AddRange(employees);
            //context.SaveChanges();

            //var employee = context.Employees.FirstOrDefault(e => e.Id == 1);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.Age ?? 0);
            //Console.WriteLine(employee?.Salary ?? 0);
            //Console.WriteLine(employee?.DeptId ?? 0);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");

            //var department = context.Departments.FirstOrDefault(e => e.Id == 100);

            //Console.WriteLine(department?.Name ?? "NA");

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //NOTE : EF Core Don't Loading Any Navigational Property

            //EF Core Loading Navigational Property
            //1. Explicit Loading
            //2. Eager Loading
            //3. Lazy Loading


            #region Explicit Loading
            //1. Explicit Loading
            //var employee = context.Employees.FirstOrDefault(e => e.Id == 1);
            //context.Entry(employee).Reference(e => e.WorkFor).Load();

            //Console.WriteLine(employee.WorkFor.Name);

            //var department = context.Departments.FirstOrDefault(e => e.Id == 100);
            //context.Entry(department).Collection(d => d.Employees).Load();

            //Console.WriteLine(department?.Name ?? "NA");

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion

            #region Eager Loading
            //2. Eager Loading

            //var employee = context.Employees.Include(e => e.WorkFor).FirstOrDefault(e => e.Id == 1);

            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.Age ?? 0);
            //Console.WriteLine(employee?.Salary ?? 0);
            //Console.WriteLine(employee?.DeptId ?? 0);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");

            //var department = context.Departments.Include(d=>d.Employees).FirstOrDefault(e => e.Id == 100);

            //Console.WriteLine(department?.Name ?? "NA");

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion

            #region Lazy Loading
            //3. Lazy Loading
            //3.1. Install Package Proxies
            //3.2. Update OnConfiguring(), Use UseLazyLoadingProxies()
            //3.3. Make All Entities Public
            //3.4. Make All Navegational Properties Virtual

            //var employee = context.Employees.FirstOrDefault(e => e.Id == 1);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.Age ?? 0);
            //Console.WriteLine(employee?.Salary ?? 0);
            //Console.WriteLine(employee?.DeptId ?? 0);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA"); 
            #endregion 
            #endregion

            #region Join Operator
            //// Join Operator

            //var result = context.Employees.Join(context.Departments, e => e.DeptId, d => d.Id, (e, d) => new
            //{
            //    EmpId = e.Id,
            //    EmpName = e.Name,
            //    DeprId = d.Id,
            //    DeptName = d.Name
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //result = from e in context.Employees
            //         join d in context.Departments
            //         on e.DeptId equals d.Id
            //         select new
            //         {
            //             EmpId = e.Id,
            //             EmpName = e.Name,
            //             DeprId = d.Id,
            //             DeptName = d.Name
            //         };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Tracking
            ////Tracking

            //var result = context.Employees.AsNoTracking().FirstOrDefault();
            //Console.WriteLine(context.Entry(result).State); // Detached
            //result.Name = "Ali"; //Local
            //context.SaveChanges(); 
            #endregion

            #region Local - Remote

            // Local - Remote


            ////Remotly
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();


            ////Local
            //context.Employees.Load();

            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();

            #endregion





        }
    }
}
