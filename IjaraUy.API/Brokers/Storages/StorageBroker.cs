using EFxceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace IjaraUy.API.Brokers.Storages
{
    public class StorageBroker : EFxceptionsContext
    {
        private readonly IConfiguration configuration;

        public StorageBroker(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Ensure the configuration and connection string are valid
            string connectionString = 
                this.configuration.GetConnectionString(name:"DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }

        public override void Dispose() {}

    }
}
