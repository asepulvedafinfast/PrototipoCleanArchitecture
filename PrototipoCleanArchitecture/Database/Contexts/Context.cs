namespace PrototipoCleanArchitecture.Database.Contexts
{
    public class Context : DbContext, IUnitOfWork
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
           return await base.SaveChangesAsync(cancellationToken);
        }

        public virtual DbSet<ActividadEconomicaDeudor> ActividadEconomicaDeudores { get; set; }
    }
}
