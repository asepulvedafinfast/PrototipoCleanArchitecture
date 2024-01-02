namespace PrototipoCleanArchitecture.Application.Response
{
    public record ActividadEconomicaDeudorResponse(
       long Id,string RutDeudor, int Codigo, string? Descripcion, DateTime? FechaIngreso);
}
