using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCApp.Data;
using System;
using System.Linq;

namespace MVCApp.Models
{
    public static class SeedData
    {   
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<MVCAppContext>>()))
            {
                // Look for any movies
                if(context.Movie.Any())
                {
                    return; //Database has been seeded
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When HArry met Sally",
                        RealeseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Goshbusters",
                        RealeseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "PG-13"
                    },
                    new Movie
                    {
                        Title = "Goshbusters 2",
                        RealeseDate = DateTime.Parse("1989-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "PG-13"
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        RealeseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "R"
                    }
                );

            }
        }

    }
}
