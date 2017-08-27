using System.Threading.Tasks;

namespace Vega.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public VegaDbContext Context { get; set; }
        public UnitOfWork(VegaDbContext context)
        {
            this.Context = context;

        }

        public async Task CompleteAsync()
        {
            await Context.SaveChangesAsync();
        }
    }
}