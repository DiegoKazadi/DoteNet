using AppAcoes.Models;
using Microsoft.EntityFrameworkCore;


namespace AppAcoes.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Acoes> Acoes { get; set; }

    }
}
