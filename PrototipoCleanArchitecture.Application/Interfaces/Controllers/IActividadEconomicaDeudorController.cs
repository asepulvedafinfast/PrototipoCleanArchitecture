using PrototipoCleanArchitecture.Application.Features.ActividadEconomicaDeudores.Command.Create;

namespace PrototipoCleanArchitecture.Application.Interfaces.Controllers
{
    public interface IActividadEconomicaDeudorController
    {
        Task<Unit> Create(CreateActividadEconomicaDeudorCommand command);
        Task<List<ActividadEconomicaDeudorResponse>> GetAll();
        Task<ActividadEconomicaDeudorResponse> GetByRutDeudor(string rut);
    }
}
