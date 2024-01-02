namespace PrototipoCleanArchitecture.Application.Features.ActividadEconomicaDeudores.Queries.GetAll
{
    internal sealed class GetAllActividadEconomicaDeudorQueryHandler :
        IRequestHandler<GetAllActividadEconomicaDeudorQuery, List<ActividadEconomicaDeudorResponse>>
    {
        private readonly IActividadEconomicaDeudorRepository _repository;

        public GetAllActividadEconomicaDeudorQueryHandler(IActividadEconomicaDeudorRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<List<ActividadEconomicaDeudorResponse>> Handle(
            GetAllActividadEconomicaDeudorQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();

            return data.Select(
                p => new ActividadEconomicaDeudorResponse(
                    p.Id,
                    p.RutDeudor,
                    p.Codigo,
                    p.Descripcion, 
                    p.FechaIngreso))
                .ToList();
        }

    }
}
