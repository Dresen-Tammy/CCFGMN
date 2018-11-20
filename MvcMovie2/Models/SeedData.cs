
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie2.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovie2Context(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovie2Context>>()))
            {
                // Look for movies.
                if (context.Movie.Any())
                {
                    return; // Db has already been seeded

                }

                context.Movie.AddRange(

                new Movie
                {
                    Title = "The Other Side of Heaven",
                    ReleaseDate = DateTime.Parse("2002-04-12"),
                    Genre = "Drama",
                    Price = 14.99M,
                    Rating = "PG"

                },
                new Movie
                {
                    Title = "Once I Was a Beehive",
                    ReleaseDate = DateTime.Parse("2015-06-19"),
                    Genre = "Comedy",
                    Price = 12.50M,
                    Rating = "PG"

                },
                new Movie
                {
                    Title = "17 Miracles",
                    ReleaseDate = DateTime.Parse("2011-11-20"),
                    Genre = "Drama",
                    Price = 27.97M,
                    Rating = "PG"

                },
                new Movie
                {
                    Title = "Meet the Mormons",
                    ReleaseDate = DateTime.Parse("2014-05-01"),
                    Genre = "Documentary",
                    Price = 9.99M,
                    Rating = "PG"

                },
                new Movie
                {
                    Title = "Saints and Soldiers",
                    ReleaseDate = DateTime.Parse("2003-12-25"),
                    Genre = "Drama",
                    Price = 17.09M,
                    Rating = "PG-13"

                },
                new Movie
                {
                    Title = "Passage to Zarahemla",
                    ReleaseDate = DateTime.Parse("2007-09-05"),
                    Genre = "Adventure",
                    Price = 12.99M,
                    Rating = "PG"

                },
                new Movie
                {
                    Title = "The R.M.",
                    ReleaseDate = DateTime.Parse("2003-10-12"),
                    Genre = "Comedy",
                    Price = 13.97M,
                    Rating = "PG"

                }

                );
                context.SaveChanges();
            }
        }
    }
}
