using PrototipoCleanArchitecture.Application.Features.ActividadEconomicaDeudores.Command.Create;
using PrototipoCleanArchitecture.Application.Features.ActividadEconomicaDeudores.Queries.GetAll;
using PrototipoCleanArchitecture.Application.Features.ActividadEconomicaDeudores.Queries.GetByRutDeudor;


namespace PrototipoCleanArchitecture.Controllers
{
    public class ActividadEconomicaDeudorController : IActividadEconomicaDeudorController 
    { 
        private readonly IMediator _mediator;

        public ActividadEconomicaDeudorController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        public async Task<Unit> Create(CreateActividadEconomicaDeudorCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<List<ActividadEconomicaDeudorResponse>> GetAll()
        {
            return await _mediator.Send(new GetAllActividadEconomicaDeudorQuery());
        }

        public async Task<ActividadEconomicaDeudorResponse> GetByRutDeudor(string rut)
        {
            return await _mediator.Send(new GetByRutDeudorActividadEconomicaDeudorQuery(rut));
        }
    }
}
