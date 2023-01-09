using Dominio.Entidade;
using Microsoft.EntityFrameworkCore;
using System;


namespace Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<agencia>(eb =>
                {
                    eb.HasNoKey();
                    eb.ToView("agencia");
                });
            //modelBuilder
            //    .Entity<conta>(eb =>
            //    {
            //        //eb.HasNoKey();
            //        eb.ToView("conta");
            //    });
            modelBuilder
                .Entity<cartao>(eb =>
                {
                    eb.HasNoKey();
                    eb.ToView("cartao");
                });
        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
        public DbSet<agencia> agencia { get; set; }
        public DbSet<conta> conta { get; set; }
        public DbSet<cartao> cartao { get; set; }
    }
}
