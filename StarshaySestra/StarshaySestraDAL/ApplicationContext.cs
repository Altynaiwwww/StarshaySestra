using Microsoft.EntityFrameworkCore;


using StarshaySestra.StarshaySestraDAL.Entity;

namespace StarshaySestra.StarshaySestraDAL
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Manager> Managers{ get; set; }
        public DbSet<User> User{ get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;" +
                "Port=5433;" +
                "Database=Users;" +
                "Username=postgres;" +
                "Password=zaqwsxzaq");
        }
       
        

    
    }
}
