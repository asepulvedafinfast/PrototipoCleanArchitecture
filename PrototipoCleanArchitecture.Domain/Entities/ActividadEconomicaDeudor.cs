namespace PrototipoCleanArchitecture.Domain.Entities
{
    public class ActividadEconomicaDeudor
    {
        public long Id { get; set; }

        public string RutDeudor { get; set; } = null!;

        public int Codigo { get; set; }

        public string? Descripcion { get; set; }

        public DateTime? FechaIngreso { get; set; }
    }
}
