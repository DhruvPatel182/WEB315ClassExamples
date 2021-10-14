using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MarvelHeros.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MarvelHerosHeroContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MarvelHerosHeroContext>>()))
            {
                // Look for any heroes
                if (context.Hero.Any())
                {
                    return;   // DB has been seeded
                }

                context.Hero.AddRange(
                    new Hero
                    {
                        Name = "Spiderman",
                        PowerAcquisitionDate = DateTime.Parse("1989-2-12"),
                        SecretIdentity = "Peter Parker",
                        Age = 26,
                        CountryOfOrigin = "USA"
                    },
                    new Hero
                    {
                        Name = "Ironman",
                        PowerAcquisitionDate = DateTime.Parse("1989-2-12"),
                        SecretIdentity = "Tony Stark",
                        Age = 50,
                        CountryOfOrigin = "USA"
                    },
                    new Hero
                    {
                        Name = "Wolverine",
                        PowerAcquisitionDate = DateTime.Parse("1989-2-12"),
                        SecretIdentity = "Logan",
                        Age = 100,
                        CountryOfOrigin = "Canada"
                    },
                    new Hero
                    {
                        Name = "The Hulk",
                        PowerAcquisitionDate = DateTime.Parse("1989-2-12"),
                        SecretIdentity = "Bruce Banner",
                        Age = 45,
                        CountryOfOrigin = "USA"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}