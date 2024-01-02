namespace PrototipoCleanArchitecture.Application.Features.ActividadEconomicaDeudores.Queries.GetByRutDeudor
{
    internal sealed class GetByRutDeudorActividadEconomicaDeudorQueryHandler : 
        IRequestHandler<GetByRutDeudorActividadEconomicaDeudorQuery, ActividadEconomicaDeudorResponse>
    {
        private readonly IActividadEconomicaDeudorRepository _repository;

        public GetByRutDeudorActividadEconomicaDeudorQueryHandler(IActividadEconomicaDeudorRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<ActividadEconomicaDeudorResponse> 
            Handle(GetByRutDeudorActividadEconomicaDeudorQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByRutDeudorAsync(request.Rut);

            if (data == null) throw new Exception("El registro no existe");

            return new ActividadEconomicaDeudorResponse(data.Id, data.RutDeudor, data.Codigo,data.Descripcion, data.FechaIngreso);
        }
    }
}
