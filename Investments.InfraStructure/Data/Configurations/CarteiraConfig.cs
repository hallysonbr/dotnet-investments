using Investments.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Investments.InfraStructure.Data.Configurations
{
    public class CarteiraConfig : IEntityTypeConfiguration<Carteira>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Carteira> builder)
        {
            builder.ToTable("Carteiras");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Saldo)
                   .IsRequired();
        }
    }
}