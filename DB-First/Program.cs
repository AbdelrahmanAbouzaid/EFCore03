using DB_First.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DB_First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Scaffold-DbContext "Server =.; Database=Northwind; Trusted_Connection=True; TrustServerCertificate=True"
            //Microsoft.EntityFrameworkCore.SqlServer -Context AppDbContext -ContextDir Data/Contexts -OutputDir Data/Models

            using AppDbContext context = new AppDbContext();

            //var result = context.Categories;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CategoryName);
            //}



            // Run SQL Query
            // 1. Select Statment : FromSqlRaw() , FromSqlInterpolated()  
            var result = context.Categories.FromSqlRaw("select * from Categories");
            foreach (var category in result)
            {
                Console.WriteLine(category.CategoryName);
            }

            // 2. DML Statment [Update - Insert - Delete]: ExecueSqlRaw() ,  ExecuteSqlInterpolated()  


        }
    }
}
