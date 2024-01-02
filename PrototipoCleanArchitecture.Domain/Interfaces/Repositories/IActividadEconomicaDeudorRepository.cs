namespace PrototipoCleanArchitecture.Domain.Interfaces.Repositories
{
    public interface IActividadEconomicaDeudorRepository
    {
        void Add(ActividadEconomicaDeudor actividadEconomicaDeudor);
        void Update(ActividadEconomicaDeudor actividadEconomicaDeudor);
        void Delete(ActividadEconomicaDeudor actividadEconomicaDeudor);
        Task<List<ActividadEconomicaDeudor>> GetAllAsync();
        Task<ActividadEconomicaDeudor?> GetByRutDeudorAsync(string rut);
    }
}
