using Microsoft.EntityFrameworkCore;

namespace ArthrpodaASP.Models
{
    public class ArthropodaDbContext : DbContext
    {
        public ArthropodaDbContext (DbContextOptions<ArthropodaDbContext> options)
            :base (options)
            {
            }
            public DbSet<InfraOrder> InfraOrders {get; set;}

            public DbSet<Family> Familys {get; set;}

            public DbSet<Genera> Generas {get; set;}

            public DbSet<Order> Orders {get; set;}

            public DbSet<Familyinsect> Familyinsects {get; set;}
    }
}