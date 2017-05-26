using System;
using System.Data.Entity;
using System.Linq;
using HelloWorldApi.Core.Application;
using HelloWorldApi.DAL.Models;

namespace HelloWorldApi.DAL
{
    public class EntityDbContext : DbContext, IGenericRepository<EntityDbContext>
    {
        public EntityDbContext() : base($"name={Settings.DatabaseConfig.Connection}")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<EntityDbContext>(null);

            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => type.IsSubclassOf(typeof(BaseModel)));

            foreach (var type in types)
            {
                BaseModel.Build(modelBuilder, type);
            }

            base.OnModelCreating(modelBuilder);

        }

        public void Add(params EntityDbContext[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params EntityDbContext[] items)
        {
            throw new NotImplementedException();
        }

        public void Remove(params EntityDbContext[] items)
        {
            throw new NotImplementedException();
        }
    }
}
