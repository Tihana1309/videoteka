using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Videoteka.Data;
using System;
using System.Linq;

namespace Videoteka.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VideotekaaContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VideotekaaContext>>()))
            {
                // Look for any movies.
                if (context.Film.Any())
                {
                    return;   // DB has been seeded
                }

                context.Film.AddRange(
                    new Film
                    {
                        Title = "Home alone",
                        ReleaseDate = DateTime.Parse("1990-9-25"),
                        Genre = "Comedy",
                        
                        Price = 50.00M
                    },

                    new Film
                    {
                        Title = "Mulan ",
                        ReleaseDate = DateTime.Parse("2020-3-15"),
                        Genre = "Adventure",
                        
                        Price = 100.00M
                    },

                    new Film
                    {
                        Title = "Pinnochio",
                        ReleaseDate = DateTime.Parse("2019-12-3"),
                        Genre = "Fantasy",
                        
                        Price = 70.00M
                    },

                    new Film
                    {
                        Title = "Momentum",
                        ReleaseDate = DateTime.Parse("2015-11-20"),
                        Genre = "Action",
                        
                        Price = 20.00M
                    },
                    new Film
                    {
                        Title = "Volition",
                        ReleaseDate = DateTime.Parse("2019-4-8"),
                        Genre = "Sci-fi",
                        
                        Price = 40.00M
                    },
                    new Film
                    {
                        Title = "The platform",
                        ReleaseDate = DateTime.Parse("2019-3-5"),
                        Genre = "Sci-fi",
                        
                        Price = 60.00M
                    },
                    new Film
                    {
                        Title = "Extinction",
                        ReleaseDate = DateTime.Parse("2015-6-12"),
                        Genre = "Horror",
                        
                        Price = 60.00M
                    },
                    new Film
                    {
                        Title = "Ghosts of War",
                        ReleaseDate = DateTime.Parse("2020-2-6"),
                        Genre = "War",
                        
                        Price = 90.00M
                    },
                    new Film
                    {
                        Title = "Havana",
                        ReleaseDate = DateTime.Parse("1990-9-9"),
                        Genre = "War",
                        
                        Price = 10.00M
                    },
                    new Film
                    {
                        Title = "The Paramedic",
                        ReleaseDate = DateTime.Parse("2020-2-2"),
                        Genre = "Drama",
                        
                        Price = 80.00M
                    },
                    new Film
                    {
                        Title = "The Grifters",
                        ReleaseDate = DateTime.Parse("1990-1-1"),
                        Genre = "Drama",
                        
                        Price = 50.00M
                    },
                    new Film
                    {
                        Title = "Mary Shelly",
                        ReleaseDate = DateTime.Parse("2017-2-3"),
                        Genre = "Drama",
                        
                        Price = 20.00M
                    },
                    new Film
                    {
                        Title = "Automata",
                        ReleaseDate = DateTime.Parse("2017-2-5"),
                        Genre = "Action",
                        
                        Price = 60.00M
                    },
                    new Film
                    {
                        Title = "Tenet",
                        ReleaseDate = DateTime.Parse("2020-5-5"),
                        Genre = "Action",
                        
                        Price = 50.00M
                    },
                    new Film
                    {
                        Title = "Emperor",
                        ReleaseDate = DateTime.Parse("2020-1-1"),
                        Genre = "Action",
                        Price = 10.00M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}