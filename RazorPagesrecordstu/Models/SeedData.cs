using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesrecordstu.Data;
using System;
using System.Linq;

namespace RazorPagesrecordstu.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesrecordstuContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesrecordstuContext>>()))
            {
                // Look for any movies.
                if (context.recordstu.Any())
                {
                    return;   // DB has been seeded
                }

                context.recordstu.AddRange(
                    new recordstu
                    {
                        Name = "When Harry Met Sally",
                        DOB = DateTime.Parse("1989-2-12"),
                        Program = "Romantic Comedy",
                        Credit = 7.99M
                    },

                    new recordstu
                    {
                        Name = "Ghostbusters ",
                        DOB = DateTime.Parse("1984-3-13"),
                        Program = "Comedy",
                        Credit = 8.99M
                    },

                    new recordstu
                    {
                        Name = "Ghostbusters 2",
                        DOB = DateTime.Parse("1986-2-23"),
                        Program = "Comedy",
                        Credit = 9.99M
                    },

                    new recordstu
                    {
                        Name = "Rio Bravo",
                        DOB = DateTime.Parse("1959-4-15"),
                        Program = "Western",
                        Credit = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}