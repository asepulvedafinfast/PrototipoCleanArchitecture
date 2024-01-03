namespace PrototipoCleanArchitecture.Application.Features.ActividadEconomicaDeudores.Command.Create
{
    internal sealed class CreateActividadEconomicaDeudorCommandHandler : IRequestHandler<CreateActividadEconomicaDeudorCommand, Unit>
    {
        private readonly IActividadEconomicaDeudorRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateActividadEconomicaDeudorCommandHandler(IActividadEconomicaDeudorRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<Unit> Handle(CreateActividadEconomicaDeudorCommand request, CancellationToken cancellationToken)
        {
            var actividadEconomicaDeudor = new ActividadEconomicaDeudor()
            {
                RutDeudor = request.RutDeudor,
                Codigo = request.Codigo,
                Descripcion = request.Descripcion,
                FechaIngreso = request.FechaIngreso
            };

            //_repository.Add(actividadEconomicaDeudor);

            //var result = await _unitOfWork.SaveChangesAsync(cancellationToken);

            //if (result <= 0) throw new Exception("Error al registrar");

            return Unit.Value;
        }
    }
}
