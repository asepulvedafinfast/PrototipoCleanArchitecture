namespace PrototipoCleanArchitecture.Application.Features.ActividadEconomicaDeudores.Command.Create
{
    public sealed record CreateActividadEconomicaDeudorCommand(
        string RutDeudor, int Codigo, string? Descripcion, DateTime? FechaIngreso) : IRequest<Unit>;
}
