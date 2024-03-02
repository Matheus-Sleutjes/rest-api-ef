using Microsoft.EntityFrameworkCore;
using RestApi.Entities;

namespace RestApi.Data
{
    public class LivrosContext : DbContext
    {
        public LivrosContext(DbContextOptions<LivrosContext> options) : base(options) { }

        public DbSet<Livro> Livros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // => optionsBuilder.UseNpgsql("Host=db;Port=5000;Database=livros-db;Username=postgres;Password=admin;CommandTimeout=120;");
        => optionsBuilder.UseNpgsql("Host=db;Database=livros-db;Username=postgres;Password=admin;CommandTimeout=120;");
    }
}
