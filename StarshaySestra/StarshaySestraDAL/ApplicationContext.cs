using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StarshaySestra.StarshaySestraDAL.Entity;

namespace StarshaySestra.StarshaySestraDAL
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Manager> Managers{ get; set; }
        public DbSet<User> User{ get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(
                    @"Server=(localdb)\mssqllocaldb;Database=EFMiscellanous.ConnectionResiliency;Trusted_Connection=True",
                    options => options.EnableRetryOnFailure());
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(
                options => options.UseSqlServer(
                    "<connection string>",
                    providerOptions => providerOptions.EnableRetryOnFailure()));
        }




    }
}
