using PrototipoCleanArchitecture.Application.Features.ActividadEconomicaDeudores.Command.Create;

namespace PrototipoCleanArchitecture.WebApi
{
    public static class EndPoints
    {
        public static WebApplication UseApplicationEndPoints(this WebApplication app)
        {
            app.MapGet("/EconomicActivityDebtor",
                 async (IActividadEconomicaDeudorController controller) =>
                 {
                     var result = await controller.GetAll();

                     return Results.Ok(result);

                 });

            app.MapPost("/EconomicActivityDebtor",
                async (IActividadEconomicaDeudorController controller, CreateActividadEconomicaDeudorCommand command) =>
                {
                    var result = await controller.Create(command);

                    return Results.Ok(result);

                });


            app.MapGet("/EconomicActivityDebtor/{rut}",
                async (IActividadEconomicaDeudorController controller, string rut) =>
                {
                    var result = await controller.GetByRutDeudor(rut);

                    return Results.Ok(result);

                });


            return app;
        }
    }
}
