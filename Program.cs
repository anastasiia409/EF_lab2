using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF_lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder().AddJsonFile(path: "appsettings.json").Build();
            var optionsBuilder = new DbContextOptionsBuilder<DbContracts>();
            DbContracts _db = new DbContracts(optionsBuilder.UseSqlServer(config.GetConnectionString("Default")).Options);

            var result = _db.EmployeeProject.
                        Include(ep => ep.Employee).
                        Include(ep => ep.Project).
                        Include(ep => ep.Position).
                        OrderBy(ep => ep.EmployeeId);

            foreach (var item in result)
            {
                
                    
                Console.WriteLine($"{item.Employee.Name} {item.Employee.Surname} {item.Employee.Address} " +
                    $"{item.Employee.Description}   {item.Project.Name} {item.Project.DateOfStart} {item.Project.DateOfEnd} {item.Project.Description}" +
                    $"  {item.Position.Name} {item.Position.Salary} {item.DateOfJoin}");
            }
        }
    }
}