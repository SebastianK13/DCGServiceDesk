using Microsoft.EntityFrameworkCore;
using DarkClusterTechnologyEnterprise.Models;
using System.Threading.Tasks;
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DCGServiceDesk.Models
{
    public class AppIdentityDbContext : DbContext
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
            : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Earnings> Earnings { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Presence> Presences { get; set; }
        public DbSet<TaskSchedule> TaskSchedules { get; set; }
        public DbSet<Break> Breaks { get; set; }
        public DbSet<TimeZonesModel> Zone { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
