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
                {// Look for any Familys.
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

            using (var context = new ArthropodaDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ArthropodaDbContext>>()))
                {// Look for any Genera.
                if (context.Generas.Any())
                {
                    return; // DB has been seeded
                }

                context.Generas.AddRange(
                    new Genera
                    {
                        Name = "Aphonopelma"
                    },
                    new Genera
                    {
                        Name = "Loxosceles"
                    },
                    new Genera
                    {
                        Name = "Crossopriza"
                    },
                    new Genera
                    {
                        Name = "Phidippus"
                    },
                    new Genera
                    {
                        Name = "Hogna"
                    }

                );
            }
            using (var context = new ArthropodaDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ArthropodaDbContext>>()))
                {// Look for any Orders.
                if (context.Orders.Any())
                {
                    return; // DB has been seeded
                }
                context.Orders.AddRange(
                    new Order
                    {
                        Name = "Hymenoptera"
                    },
                    new Order
                    {
                        Name = "Coleoptera"
                    },
                    new Order
                    {
                        Name = "Diptera"
                    },
                    new Order
                    {
                        Name = "Hemiptera"
                    }
                );
            }
            using (var context = new ArthropodaDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ArthropodaDbContext>>()))
                {// Look for any Familyinsect.
                if (context.Familyinsects.Any())
                {
                    return; // DB has been seeded
                }
                context.Familyinsects.AddRange(
                    new Familyinsect
                    {
                        Name = "Vespidae"
                    },
                    new Familyinsect
                    {
                        Name = "Carabidae"
                    },
                    new Familyinsect
                    {
                        Name = "Calliphoridae"
                    },
                    new Familyinsect
                    {
                        Name = "Reduviidae"
                    }
                );
            }                            
        }
    }
}            
