using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PrototipoCleanArchitecture.Infrastructure.Database.Configuration
{
    public class ActividadEconomicaDeudorConfiguration : IEntityTypeConfiguration<ActividadEconomicaDeudor>
    {
        public void Configure(EntityTypeBuilder<ActividadEconomicaDeudor> builder)
        {
            builder.ToTable("ActividadEconomicaDeudor");

            builder.Property(e => e.Descripcion).HasMaxLength(600);
            builder.Property(e => e.FechaIngreso).HasColumnType("datetime");
            builder.Property(e => e.RutDeudor).HasMaxLength(100);
        }
    }
}
