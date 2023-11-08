
using Microsoft.EntityFrameworkCore;
using Models;

namespace ejercicioApiDwi.Contexto
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
        public DbSet<Acceso> accesos { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
    }
}
