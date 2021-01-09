using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using QSolzao.Domain.Entity;

namespace QSolzao.Infra.Data.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {

        }

        public DbSet<Cambista> Cambistas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cambista>().ToTable("Tb_cambista");

        }
    }

}
