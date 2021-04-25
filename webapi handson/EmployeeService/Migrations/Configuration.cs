namespace EmployeeService.Migrations
{
    using EmployeeService.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeService.Models.EmployeeServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeService.Models.EmployeeServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Departments.AddOrUpdate(x => x.Id,
                new Department() { Id = 100, name = "HR" },
                new Department() { Id = 101, name = "Technical" });

            context.Employees.AddOrUpdate(x => x.id,
                new Employee() { id = 1, Firstname = "John", Lastname = "Smith", DepartmentId = 101, salary = 30000 },
                new Employee() { id = 2, Firstname = "Mary", Lastname = "Jane", DepartmentId = 100, salary = 20000 },
                new Employee() { id = 3, Firstname = "Steve", Lastname = "Lopez", DepartmentId = 101, salary = 50000 });
        }
    }
}
