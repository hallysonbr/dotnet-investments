using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investments.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Investments.InfraStructure.Data.Configurations
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.DataNascimento)                   
                   .IsRequired();

            builder.Property(u => u.Nome)
                   .IsRequired();                   

            builder.Property(u => u.Email)
                  .IsRequired();

            builder.Property(u => u.Password)
                  .IsRequired();
        }
    }
}