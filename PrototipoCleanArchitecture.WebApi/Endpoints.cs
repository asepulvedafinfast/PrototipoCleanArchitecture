using PrototipoCleanArchitecture.Application.Interfaces.Controllers;

namespace PrototipoCleanArchitecture.WebApi
{
    public static class EndPoints
    {
        public static WebApplication UseApplicationEndPoints(this WebApplication app)
        {
            app.MapGet("/specials",
                 async (IActividadEconomicaDeudorController controller) =>
                 {
                     var Result = await controller.GetAll();

                     return Results.Ok(Result);

                 });


            return app;
        }
    }
}
