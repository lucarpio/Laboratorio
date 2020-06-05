using Microsoft.EntityFrameworkCore;
namespace Laboratorio.Data

{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }
        public DbSet<Laboratorio.Models.Empleado> Empleados { get; set; }
    }
}