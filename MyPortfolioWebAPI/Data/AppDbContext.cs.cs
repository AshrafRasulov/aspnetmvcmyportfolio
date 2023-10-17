using Microsoft.EntityFrameworkCore;


namespace MyPortfolioWebAPI.Data
{
    public class AppDbContext : DbContext
    {
#pragma warning disable CS8618
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option){}
#pragma warning restore CS8618


        
        public DbSet<User> Users  { get; set; }

    }
}
