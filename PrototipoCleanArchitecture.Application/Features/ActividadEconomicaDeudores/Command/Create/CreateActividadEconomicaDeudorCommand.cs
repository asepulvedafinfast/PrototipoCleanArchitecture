namespace PrototipoCleanArchitecture.Application.Features.ActividadEconomicaDeudores.Command.Create
{
    public record CreateActividadEconomicaDeudorCommand(
        string RutDeudor, int Codigo, string? Descripcion, DateTime? FechaIngreso) : IRequest<Unit>;
}
