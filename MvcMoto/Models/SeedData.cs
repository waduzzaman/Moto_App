using Microsoft.EntityFrameworkCore;
using MvcMoto.Data;

namespace MvcMoto.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMotoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMotoContext>>()))
            {
                // Look for any movies.
                if (context.Moto.Any())
                {
                    return;   // DB has been seeded
                }
                context.Moto.AddRange(
                    new Moto
                    {
                        Name = "Joey Logano",
                        Circuit = "NASCAR Cup",
                        Team = "Team Penske",
                        WorldRank = 1,
                        DriverNumber = 2,
                    }
                    
                   
                   
                );
                context.SaveChanges();
            }
        }
    }
}
