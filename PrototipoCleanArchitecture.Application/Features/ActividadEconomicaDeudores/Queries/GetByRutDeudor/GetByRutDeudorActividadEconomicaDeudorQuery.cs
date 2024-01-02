namespace PrototipoCleanArchitecture.Application.Features.ActividadEconomicaDeudores.Queries.GetByRutDeudor
{
    public record GetByRutDeudorActividadEconomicaDeudorQuery(string Rut) : IRequest<ActividadEconomicaDeudorResponse>;
    
}
