using EF_lab2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.Common;


namespace EF_lab2
{
    public class DbContracts: DbContext
    {
        public DbContracts(DbContextOptions<DbContracts> options) : base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; } = null!;
        public DbSet<Project> Project { get; set; } = null!;
        public DbSet<Position> Position { get; set; } = null!;
        public DbSet<EmployeeProject> EmployeeProject { get; set; } = null!;
    }
}
