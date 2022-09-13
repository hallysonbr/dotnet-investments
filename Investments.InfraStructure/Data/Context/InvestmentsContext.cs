using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Investments.Core.Entities;
using Investments.InfraStructure.Data.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Investments.InfraStructure.Data.Context
{
    public class InvestmentsContext : DbContext
    {
        public InvestmentsContext(DbContextOptions<InvestmentsContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Ativo> Ativos { get; set; }
        public DbSet<Carteira> Carteiras { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(255)");

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}