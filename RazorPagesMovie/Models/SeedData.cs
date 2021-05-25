using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Categoria = "Ingles",
                        Pacote = "Bimestre 01",
                    },

                    new Movie
                    {
                        Categoria = "Matematica",
                        Pacote = "Bimestre 01",
                    },

                    new Movie
                    {
                        Categoria = "Portugues",
                        Pacote = "Bimestre 01",

                    },

                    new Movie
                    {
                        Categoria = "Geografia",
                        Pacote = "Bimestre 01",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}