using Microsoft.EntityFrameworkCore;
using RestApi.Entities;

namespace RestApi.Data
{
    public class LivrosContext : DbContext
    {
        public LivrosContext(DbContextOptions<LivrosContext> options) : base(options) { }
        public DbSet<Livro> Livros { get; set; }
    }
}
