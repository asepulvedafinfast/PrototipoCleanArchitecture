namespace PrototipoCleanArchitecture.Application.Features.ActividadEconomicaDeudores.Queries.GetByRutDeudor
{
    public sealed record GetByRutDeudorActividadEconomicaDeudorQuery(string Rut) : IRequest<ActividadEconomicaDeudorResponse>;
    
}
