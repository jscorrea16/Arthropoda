using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ArthrpodaASP.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ArthropodaDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ArthropodaDbContext>>()))
                {// Look for any Infra Orders.
                if (context.InfraOrders.Any())
                {
                    return; // DB has been seeded
                }

                context.InfraOrders.AddRange(
                    new InfraOrder
                    {
                        Name = "Mygalomorphae"   
                    },
                    new InfraOrder
                    {
                        Name = "Araneomorphae"
                        
                    }
                );
                
                context.SaveChanges();
            }

            using (var context = new ArthropodaDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ArthropodaDbContext>>()))
                {// Look for any Infra Orders.
                if (context.Familys.Any())
                {
                    return; // DB has been seeded
                }

                context.Familys.AddRange(
                    new Family
                    {
                        Name = "Theraphosidae"   
                    },
                    new Family
                    {
                        Name = "Sicariidae"    
                    },
                    new Family
                    {
                        Name = "Pholcidae"
                    },
                    new Family
                    {
                        Name = "Salticidae"
                    },
                    new Family
                    {
                        Name = "Lycosidae"
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}            
