using Microsoft.EntityFrameworkCore;
using BlazorWebAppMovies.Models;

namespace BlazorWebAppMovies.Data;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new BlazorWebAppMoviesContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<BlazorWebAppMoviesContext>>()
        );
        if (context == null || context.Movie == null)
        {
            throw new NullReferenceException(
                    "Null BlazorWebAppMoviesContext or Movie DbSet"
            );
        }
        if (context.Movie.Any())
        {
            return;
        }
        context.Movie.AddRange(
            new Movie
            {
                Title = "When Harry Met Sally",
                ReleaseDate = new DateOnly(1989, 7, 21),
                Genre = "Romantic Comedy",
                Price = 7.99M,
                Rating = "PG"

            },
            new Movie
            {
                Title = "Ghostbusters ",
                ReleaseDate = new DateOnly(1984, 3, 13),
                Genre = "Comedy",
                Price = 8.99M,
                Rating = "PG-13"

            },
            new Movie
            {
                Title = "Ghostbusters 2",
                ReleaseDate = new DateOnly(1986, 2, 23),
                Genre = "Comedy",
                Price = 9.99M,
                Rating = "R"

            },
            new Movie
            {
                Title = "Rio Bravo",
                ReleaseDate = new DateOnly(1959, 4, 15),
                Genre = "Western",
                Price = 3.99M,
                Rating = "R"

            }
        );
        context.SaveChanges();
    }
}