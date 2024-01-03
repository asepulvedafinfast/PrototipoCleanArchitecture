namespace PrototipoCleanArchitecture.Application.Features.ActividadEconomicaDeudores.Command.Create
{
    public class CreateActividadEconomicaDeudorCommandValidator : AbstractValidator<CreateActividadEconomicaDeudorCommand>
    {
        public CreateActividadEconomicaDeudorCommandValidator()
        {
            RuleFor(p => p.RutDeudor)
                .NotEmpty().WithMessage("El rut deudor es requerido")
                .MaximumLength(100).WithMessage("El rut deudor no debe superar los 100 caracteres");

            RuleFor(p => p.Codigo).Empty().WithMessage("El codigo es requerido");

            RuleFor(p => p.Descripcion).MaximumLength(600).WithMessage("La descripcion no debe superar los 800 caracteres");
        }
    }
}
