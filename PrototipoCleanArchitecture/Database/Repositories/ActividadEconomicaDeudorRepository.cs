namespace PrototipoCleanArchitecture.Database.Repositories
{
    internal sealed class ActividadEconomicaDeudorRepository : IActividadEconomicaDeudorRepository
    {
        private readonly Context _context;

        public ActividadEconomicaDeudorRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(ActividadEconomicaDeudor actividadEconomicaDeudor) 
            => _context.ActividadEconomicaDeudores.Add(actividadEconomicaDeudor);

        public void Delete(ActividadEconomicaDeudor actividadEconomicaDeudor) 
            => _context.ActividadEconomicaDeudores.Remove(actividadEconomicaDeudor);

        public async Task<List<ActividadEconomicaDeudor>> GetAllAsync() 
            => await _context.ActividadEconomicaDeudores.ToListAsync();

        public Task<ActividadEconomicaDeudor?> GetByRutDeudorAsync(string rut)
            => _context.ActividadEconomicaDeudores.FirstOrDefaultAsync(x => x.RutDeudor == rut);

        public void Update(ActividadEconomicaDeudor actividadEconomicaDeudor)
            => _context.Update(actividadEconomicaDeudor);
    }
}
