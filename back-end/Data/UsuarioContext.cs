using Microsoft.EntityFrameworkCore;

namespace usuario.Data
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
        {
        }

        public DbSet<UsuarioContext> usuarios { get; set; }
    }
}