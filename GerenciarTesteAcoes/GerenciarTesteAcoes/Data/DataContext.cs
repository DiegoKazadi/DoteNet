using System;
using System.Collections.Generic;
using GerenciarTesteAcoes.Models;


namespace GerenciarTesteAcoes.Data
{
      public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Acao> Acao { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
