using CrudBAckend.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudBAckend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }

    }
}
