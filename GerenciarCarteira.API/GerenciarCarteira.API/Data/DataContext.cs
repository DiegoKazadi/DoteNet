using Microsoft.EntityFrameworkCore;
using GerenciarCarteira.API.Model;
using GerenciarCarteira.Domain;

namespace GerenciarCarteira.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Carteira> Carteiras { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
