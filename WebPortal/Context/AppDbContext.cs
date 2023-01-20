using Microsoft.EntityFrameworkCore;
using WebPortal.Models;

namespace WebPortal.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
