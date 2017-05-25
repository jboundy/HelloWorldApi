using System.Data.Entity;
using System.Threading.Tasks;
using HelloWorldApi.Core.Application;

namespace HelloWorldApi.DAL
{
    public class EntityContext : DbContext, IDataService
    {
        public EntityContext() : base($"name={Settings.DatabaseConfig.Connection}")
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<EntityContext>(null);

            base.OnModelCreating(modelBuilder);
            
        }

        public async Task Commit()
        {
            await SaveChangesAsync();
        }

    }
}
