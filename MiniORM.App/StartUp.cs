namespace MiniORM.App
{
    using MiniORM.App.Data.Entities;
    using System.Linq;

	public class StartUp
    {
        public static void Main(string[] args)
        {
			var connectionString = "Server=.;Database=MiniORM;Integrated Security=True";

			var context = new SoftUniDbContext(connectionString);

            context.Employees.Add(new Employee
            {
                FirstName = "Updated",
                MiddleName = "Abdalov",
                LastName = "Losho",
                DepartmentId = context.Departments.First().Id,
                IsEmployed = true,
            });

            var employee = context.Employees.Last();
            employee.FirstName = "Morb";

            context.SaveChanges();
		}
    }
}
