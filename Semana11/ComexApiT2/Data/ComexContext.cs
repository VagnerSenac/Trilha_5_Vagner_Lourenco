using ComexApiT2.Models;
using Microsoft.EntityFrameworkCore;

namespace ComexApiT2.Data
{
    public class ComexContext : DbContext
    {
        public ComexContext(DbContextOptions<ComexContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
