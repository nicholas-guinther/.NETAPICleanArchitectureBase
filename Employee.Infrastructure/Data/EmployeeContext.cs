using Microsoft.EntityFrameworkCore;

namespace Employee.Infrastructure.Data;

public class EmployeeContext : DbContext
{
    public EmployeeContext()
    {
    }

    public EmployeeContext(DbContextOptions<EmployeeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Core.Entities.Employee> Employees { get; set; } = null!;
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=EmployeeCleanArchDemo;User Id=postgres;Password={DevP@ss}");
        }
    }
}